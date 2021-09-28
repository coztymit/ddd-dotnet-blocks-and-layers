using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using exchange_application.exchange.accounting.application;
using exchange_domain.exchange.accounting.domain;
using exchange_domain.exchange.accounting.domain.policy;

namespace exchange_application.exchange.accounting.application
{
    public class InvoiceApplicationService: IInvoiceApplicationService
    {
        
        private IEnumerable<NotificationSender> senders;
        private IInvoiceRepository invoiceRepository;
        private InvoiceFactory factory;

        public InvoiceApplicationService(IEnumerable<NotificationSender> senders, IInvoiceRepository invoiceRepository)
        {
            this.senders = senders;
            this.invoiceRepository = invoiceRepository;
            factory = new InvoiceFactory();
        }

        public CreateStatus createInvoice()
        {
            //zarządzanie transakcjami
            List<IPosiionAttributes> invoicePositions = new List<IPosiionAttributes>();
            invoicePositions.Add(new InvoicePosition(100, "PLN"));

            Invoice invoice = factory.createInvoice(invoicePositions);
            invoiceRepository.save(invoice);


            //foreach (NotificationSender sender in senders) {
            //   sender.sendNotification(invoice.ToString());
            // }

            //To oczywiscie moze zostac wzbogacone
            return CreateStatus.Correct(invoice.invoiceNumber());

        }
        public CreateStatus createInvoice(string invoiceNumber)
        {
            //zarządzanie transakcjami
            List<IPosiionAttributes> invoicePositions = new List<IPosiionAttributes>();
            invoicePositions.Add(new InvoicePosition(100, "PLN"));

            Invoice invoice = factory.createInvoice(invoiceNumber, invoicePositions);
            invoiceRepository.save(invoice);


            //foreach (NotificationSender sender in senders) {
            //   sender.sendNotification(invoice.ToString());
            // }

            //To oczywiscie moze zostac wzbogacone
            return CreateStatus.Correct(invoice.invoiceNumber());

        }

        public CreateStatus createInvoiceByBookKeeper()
        {
            //Transformacja z ebiektów komunikacji
            List<IPosiionAttributes> invoicePositions = createPosition();
            
            BookKeeper bookKeeper = new BookKeeper();

            IPositionLimitPolicy limitPolicy = bookKeeper.definePositionLimitPolicy();

            Invoice invoice = bookKeeper.createInvoice(invoicePositions, limitPolicy);
            invoiceRepository.save(invoice);

            return CreateStatus.Correct(invoice.invoiceNumber());

        }

        private static List<IPosiionAttributes> createPosition()
        {
            List<IPosiionAttributes> invoicePositions = new List<IPosiionAttributes>();
            invoicePositions.Add(new InvoicePosition(100, "PLN"));
            return invoicePositions;
        }

        public CreateStatus craeteCorrection(string number)
        {
            Invoice invoice = invoiceRepository.get(new Number(number));
           
            throw new NotImplementedException();
        }

        public void ApproveInvoice(string number)
        {
            Invoice invoice = invoiceRepository.get(new Number(number));
            invoice.Approve();
            invoiceRepository.save(invoice);

            BookKeeper bookKeeper = new BookKeeper();

            Payment payment = bookKeeper.createPayment(invoice);

        }

    }
}

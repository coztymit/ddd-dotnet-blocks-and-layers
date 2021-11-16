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

        public CreateStatus CreateInvoice()
        {
            //zarządzanie transakcjami
            List<IPositionAttributes> invoicePositions = new List<IPositionAttributes>();
            invoicePositions.Add(new InvoicePosition(100, "PLN"));

            Invoice invoice = factory.CreateInvoice(invoicePositions);
            invoiceRepository.Save(invoice);


            //foreach (NotificationSender sender in senders) {
            //   sender.SendNotification(invoice.ToString());
            // }

            //To oczywiscie moze zostac wzbogacone
            return CreateStatus.Correct(invoice.InvoiceNumber());

        }
        public CreateStatus CreateInvoice(string invoiceNumber)
        {
            //zarządzanie transakcjami
            List<IPositionAttributes> invoicePositions = new List<IPositionAttributes>();
            invoicePositions.Add(new InvoicePosition(100, "PLN"));

            Invoice invoice = factory.CreateInvoice(invoiceNumber, invoicePositions);
            invoiceRepository.Save(invoice);


            //foreach (NotificationSender sender in senders) {
            //   sender.SendNotification(invoice.ToString());
            // }

            //To oczywiscie moze zostac wzbogacone
            return CreateStatus.Correct(invoice.InvoiceNumber());

        }

        public CreateStatus CreateInvoiceByBookKeeper()
        {
            //Transformacja z ebiektów komunikacji
            List<IPositionAttributes> invoicePositions = CreatePosition();
            
            BookKeeper bookKeeper = new BookKeeper();

            IPositionLimitPolicy limitPolicy = bookKeeper.DefinePositionLimitPolicy();

            Invoice invoice = bookKeeper.CreateInvoice(invoicePositions, limitPolicy);
            invoiceRepository.Save(invoice);

            return CreateStatus.Correct(invoice.InvoiceNumber());

        }

        private static List<IPositionAttributes> CreatePosition()
        {
            List<IPositionAttributes> invoicePositions = new List<IPositionAttributes>();
            invoicePositions.Add(new InvoicePosition(100, "PLN"));
            return invoicePositions;
        }

        public CreateStatus CreateCorrection(string number)
        {
            Invoice invoice = invoiceRepository.Get(new Number(number));
           
            throw new NotImplementedException();
        }

        public void ApproveInvoice(string number)
        {
            Invoice invoice = invoiceRepository.Get(new Number(number));
            invoice.Approve();
            invoiceRepository.Save(invoice);

            BookKeeper bookKeeper = new BookKeeper();

            Payment payment = bookKeeper.CreatePayment(invoice);
            //dalej dzałamy z payment
        }

    }
}

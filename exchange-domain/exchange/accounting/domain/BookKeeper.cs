using System;
using System.Collections.Generic;
using exchange_domain.exchange.accounting.domain.policy;

namespace exchange_domain.exchange.accounting.domain
{
    public class BookKeeper
    {
        InvoiceFactory factory = new InvoiceFactory();

        public BookKeeper()
        {

        }

        public Invoice createInvoice(List<IPosiionAttributes> possitionAttributes, IPositionLimitPolicy limitPolicy)
        {
            //Okresla polityki 
            return factory.createInvoice(possitionAttributes, limitPolicy);
        }

        public Invoice createInvoiceCorrection(List<IPosiionAttributes> possitionAttributes)
        {
            return factory.createInvoice(possitionAttributes);
        }

        public Payment createPayment(Invoice invoice)
        {
            // na podstawie warunków biznesowych tworzy nowey obiekt platnosci 
            return new Payment();
        }

        public IPositionLimitPolicy definePositionLimitPolicy()
        {
            //tu powinna byc implementacja przypadkow okreslania polityki 
            return new PLNPositionLimitPolicy();
        }
    }
}

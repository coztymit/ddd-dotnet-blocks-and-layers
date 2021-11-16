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

        public Invoice CreateInvoice(List<IPositionAttributes> positionAttributes, IPositionLimitPolicy limitPolicy)
        {
            //Okresla polityki 
            return factory.CreateInvoice(positionAttributes, limitPolicy);
        }

        public Invoice CreateInvoiceCorrection(List<IPositionAttributes> possitionAttributes)
        {
            return factory.CreateInvoice(possitionAttributes);
        }

        public Payment CreatePayment(Invoice invoice)
        {
            // na podstawie warunków biznesowych tworzy nowey obiekt platnosci 
            return new Payment();
        }

        public IPositionLimitPolicy DefinePositionLimitPolicy()
        {
            //tu powinna byc implementacja przypadkow okreslania polityki 
            return new PLNPositionLimitPolicy();
        }
    }
}

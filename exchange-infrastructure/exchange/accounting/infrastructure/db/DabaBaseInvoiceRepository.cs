using System;
using itmdevlabs_currency_exchange.exchange.accounting.domain;

namespace currency_exchange.exchange.accounting.infrastructure
{
    public class DabaBaseInvoiceRepository : IInvoiceRepository
    {
        public Invoice find(Number number)
        {
            throw new NotImplementedException();
        }

        public Invoice get(Number number)
        {
            throw new NotImplementedException();
        }

        public void save(Invoice invoice)
        {
            Console.WriteLine(invoice.ToString());
           
        }
    }
}

using System;
using exchange_domain.exchange.accounting.domain;

namespace exchange_infrastructure.exchange.accounting.infrastructure.db
{
    public class DabaBaseInvoiceRepository : IInvoiceRepository
    {
        public Invoice Find(Number number)
        {
            throw new NotImplementedException();
        }

        public Invoice Get(Number number)
        {
            throw new NotImplementedException();
        }

        public void Save(Invoice invoice)
        {
            Console.WriteLine(invoice.ToString());
           
        }
    }
}

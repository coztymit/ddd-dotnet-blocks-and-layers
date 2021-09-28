using System;
using exchange_domain.exchange.accounting.domain;

namespace exchange_infrastructure.exchange.accounting.infrastructure.db
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

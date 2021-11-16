using System;

namespace exchange_domain.exchange.accounting.domain
{
   public interface IInvoiceRepository
    {
       void Save(Invoice invoice);
       Invoice Get(Number number);
       Invoice Find(Number number);
    }
}

using System;

namespace exchange_domain.exchange.accounting.domain
{
   public interface IInvoiceRepository
    {
       void save(Invoice invoice);
       Invoice get(Number number);
       Invoice find(Number number);
    }
}

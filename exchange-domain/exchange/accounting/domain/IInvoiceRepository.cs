using System;

namespace itmdevlabs_currency_exchange.exchange.accounting.domain
{
   public interface IInvoiceRepository
    {
       void save(Invoice invoice);
       Invoice get(Number number);
       Invoice find(Number number);
    }
}

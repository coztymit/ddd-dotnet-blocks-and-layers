using System;
namespace itmdevlabs_currency_exchange.exchange.accounting.domain
{
    public interface IPosiionAttributes
    {
         string productNumber();
         Decimal productValue();
         String valueCurrency();
        
    }
}
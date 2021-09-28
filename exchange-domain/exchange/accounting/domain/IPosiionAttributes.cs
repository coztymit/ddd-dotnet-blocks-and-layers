using System;
namespace exchange_domain.exchange.accounting.domain
{
    public interface IPosiionAttributes
    {
         string productNumber();
         Decimal productValue();
         String valueCurrency();
        
    }
}
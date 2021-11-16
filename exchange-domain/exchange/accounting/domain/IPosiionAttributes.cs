using System;
namespace exchange_domain.exchange.accounting.domain
{
    public interface IPosiionAttributes
    {
         string ProductNumber();
         Decimal ProductValue();
         String ValueCurrency();
        
    }
}
using System;
namespace exchange_domain.exchange.accounting.domain
{
    public interface IPositionAttributes
    {
         string ProductNumber();
         Decimal ProductValue();
         String ValueCurrency();
        
    }
}
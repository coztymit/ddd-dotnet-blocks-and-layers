using System;
namespace exchange_domain.exchange.accounting.domain.exceptions
{
    public class DifferentCurrenciesException : Exception
    {
        public DifferentCurrenciesException(String firstCurrency, String secoundSurrency)
        {

        }
    }
}

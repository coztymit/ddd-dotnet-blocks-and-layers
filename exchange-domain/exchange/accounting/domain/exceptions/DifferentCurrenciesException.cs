using System;
namespace exchange_domain.exchange.accounting.domain.exceptions
{
    public class DifferentCurrenciesException : Exception
    {
        public DifferentCurrenciesException(string firstCurrency, string secoundSurrency)
        {

        }
    }
}

using System;
namespace itmdevlabs_currency_exchange.exchange.accounting.domain.exceptions
{
    public class DifferentCurrenciesException : Exception
    {
        public DifferentCurrenciesException(String firstCurrency, String secoundSurrency)
        {

        }
    }
}

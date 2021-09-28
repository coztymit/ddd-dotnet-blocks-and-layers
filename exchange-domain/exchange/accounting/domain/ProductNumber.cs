using System;

namespace itmdevlabs_currency_exchange.exchange.accounting.domain
{
    class ProductNumber
    {
        private String number;

        public ProductNumber(String number)
        {
            //TODO walidacja 
            this.number = number;
        }
    }
}
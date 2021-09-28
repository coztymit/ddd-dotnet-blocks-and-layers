using System;

namespace exchange_domain.exchange.accounting.domain
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
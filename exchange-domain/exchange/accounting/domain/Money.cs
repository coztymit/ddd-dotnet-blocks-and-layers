using System;
using System.Collections.Generic;
using exchange_domain.exchange.accounting.domain.exceptions;

namespace exchange_domain.exchange.accounting.domain
{
    //VO odpowiedzialny za przetrzymywanie wartości pieniądza oraz waluty 
    class Money
    {
        public static Money ZERO_PLN = new Money(0);
        private Decimal value;
        private Currency currency;


        public Money(Decimal value)
        {
            this.value = value;
            currency = Currency.DEFAULT;
        }
        public Money(Decimal value, Currency currency)
        {
            this.value = value;
            this.currency = currency;
        }

        public Money Add(Money money)
        {
            if (!this.currency.Equals(money.currency))
            {
                //TODO specify exception 
                throw new Exception();
            }
            return new Money(this.value + money.value, this.currency);
        }

        public Money Sub(Money money)
        {
            if (!this.currency.Equals(money.currency))
            {
                //TODO specify exception 
                throw new Exception();
            }
            return new Money(this.value - money.value, this.currency);
        }

        public Money Add(Money money, Money money2)
        {
            if (!money2.currency.Equals(money.currency))
            {
                throw new DifferentCurrenciesException(money.currency.ToString(), money2.currency.ToString());
            }
            return new Money(money.value + money2.value, this.currency);
        }

        public override bool Equals(object obj)
        {
            return obj is Money money && obj!=null && currency.Equals(money.currency) && 
                   value == money.value;

        }
        public override string ToString()
        {
            return value.ToString() + " currency:" + this.currency.ToString();
        }

        internal bool lessThan(Money valueToCompere)
        {
            //NIE WIEM CZY TO JEST DOBRZE NAPISANE - TESTY JEDNOSTKOWE!!! 
            if (Decimal.Compare(this.value, valueToCompere.value) < 0)
            {
                return true;
            }
            return false;
        }
    }
}

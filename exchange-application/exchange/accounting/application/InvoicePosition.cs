using System;
using exchange_domain.exchange.accounting.domain;

namespace exchange_application.exchange.accounting.application
{
    public class InvoicePosition : IPositionAttributes
    {
        private string number;
        private decimal value;
        private string currency;

        public InvoicePosition(decimal productValue, string currency)
        {
            this.number = "randomnumber";
            this.value = productValue;
            this.currency = currency;
        }

        public string ProductNumber()
        {
            return number;
        }

        public decimal ProductValue()
        {
            return value;
        }

        public string ValueCurrency()
        {
            return currency;
        }
    }
}

namespace exchange_domain.exchange.accounting.domain
{
    class Currency
    {
        public static Currency DEFAULT = new Currency("PLN");
        private string value;

        public Currency(string value)
        {
            if (value.Length != 3)
            {
                throw new System.Exception();
            }
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Currency currency &&
                   value == currency.value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
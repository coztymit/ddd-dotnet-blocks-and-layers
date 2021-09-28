using System;
namespace exchange_domain.exchange.accounting.domain
{
    public class Number
    {
        private Guid number;
        public Number()
        {
            number = System.Guid.NewGuid();
        }

        public Number(string number)
        {
            this.number = System.Guid.Parse(number);
        }

        public override string ToString()
        {
            return number.ToString();
        }
    }
}

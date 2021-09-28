using System;

namespace itmdevlabs_currency_exchange.exchange.accounting.domain
{
    class PositionBusinessId
    {
        private Guid number;
        public PositionBusinessId()
        {
            number = System.Guid.NewGuid();
        }

        public override string ToString()
        {
            return number.ToString();
        }
    }
}
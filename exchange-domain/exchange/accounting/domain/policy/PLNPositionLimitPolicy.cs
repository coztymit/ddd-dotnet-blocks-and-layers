using System;
namespace itmdevlabs_currency_exchange.exchange.accounting.domain.policy
{
    public class PLNPositionLimitPolicy : IPositionLimitPolicy
    {
        private int positionLimit = 10;

        public PLNPositionLimitPolicy()
        {
        }

        public bool lessOrEqualsLimit(int positionsCount)
        {
            return positionLimit >= positionsCount;
        }
    }
}

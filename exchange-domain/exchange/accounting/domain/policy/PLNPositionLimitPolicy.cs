using System;
namespace exchange_domain.exchange.accounting.domain.policy
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

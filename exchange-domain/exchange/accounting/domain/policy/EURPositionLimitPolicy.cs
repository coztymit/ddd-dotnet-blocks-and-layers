using System;
namespace exchange_domain.exchange.accounting.domain.policy
{
    public class EURPositionLimitPolicy : IPositionLimitPolicy
    {
        private int positionLimit = 5;

        public EURPositionLimitPolicy()
        {
        }

        public bool lessOrEqualsLimit(int positionsCount)
        {
            return positionLimit >= positionsCount;
        }
    }
}

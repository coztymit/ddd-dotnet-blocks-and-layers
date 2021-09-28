using System;
namespace itmdevlabs_currency_exchange.exchange.accounting.domain.policy
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

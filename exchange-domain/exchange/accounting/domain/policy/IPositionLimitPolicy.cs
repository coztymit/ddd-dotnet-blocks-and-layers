using System;
namespace exchange_domain.exchange.accounting.domain.policy
{
    public interface IPositionLimitPolicy
    {
        bool lessOrEqualsLimit(int positionsCount);
    }
}

using System;
namespace itmdevlabs_currency_exchange.exchange.accounting.domain.policy
{
    public interface IPositionLimitPolicy
    {
        bool lessOrEqualsLimit(int positionsCount);
    }
}

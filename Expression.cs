using System;

namespace TDD_Money
{
    public interface Expression
    {
        Money Reduce(Bank bank, String toCurrency);
    }
}
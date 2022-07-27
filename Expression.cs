using System;

namespace TDD_Money
{
    public interface Expression
    {
        Money Reduce(Bank bank, String toCurrency);
        Expression Plus(Expression addend);
        Expression Times(int i);
    }
}
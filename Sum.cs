using System;

namespace TDD_Money
{
    public class Sum : Expression
    {
        public readonly Money Augend;
        public readonly Money Addend;

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank, String toCurrency)
        {
            int amount = Addend.Amount + Augend.Amount;
            return new Money(amount, toCurrency).Reduce(bank, toCurrency);
        }
    }
}
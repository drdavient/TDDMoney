using System;

namespace TDD_Money
{
    public class Sum : Expression
    {
        public readonly Expression Augend;
        public readonly Expression Addend;

        public Sum(Expression augend, Expression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank, String toCurrency)
        {
            int amount = Addend.Reduce(bank, toCurrency).Amount + Augend.Reduce(bank,toCurrency).Amount;
            return new Money(amount, toCurrency);
        }

        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Expression Times(int multiplier)
        {
            return new Sum(Augend. Times( multiplier), Addend.Times(multiplier));
        }
    }
}
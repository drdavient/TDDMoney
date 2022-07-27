using System;

namespace TDD_Money
{
    public class Money : Expression

    {
        internal readonly int Amount;
        private readonly string _currency;

        public Money(int amount, string currency)
        {
            this.Amount = amount;
            this._currency = currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public override bool Equals(Object obj)
        {
            Money money = (Money) obj;
            return money.Amount == this.Amount
                   && _currency.Equals(money._currency);
        }


        public Expression Times(int multiplier)
        {
            return new Money(Amount * multiplier, _currency);
        }

        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public string Currency()
        {
            return this._currency;
        }

        public override string ToString()
        {
            return Amount + " " + _currency;
        }

        public Money Reduce(Bank bank, string toCurrency)
        {
            var rate = bank.Rate(_currency, toCurrency);
            return new Money(Amount/rate,toCurrency);
        }

       
    }
}

using System;
using Xunit;
using TDD_Money;

namespace TestMoney
{
    public class Tests
    {
        [Fact]
        public void TestDollarMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.True(Money.Dollar(10).Equals(five.Times(2)));
            Assert.True(Money.Dollar(15).Equals(five.Times(3)));
        }

        [Fact]
        public void TestSimpleAddition()
        {
            Money five = new Money(5, "USD");
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(10), reduced);

        }

        [Fact]
        public void TestPlusReturnsSum()
        {
            Money five = new Money(5, "USD");
            Expression result = five.Plus(five);
            Sum sum = (Sum) result;
            Assert.Equal(five, sum.Augend);
            Assert.Equal(five, sum.Addend);
        }

        [Fact]
        public void TestReduceSum()
        {
            Expression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(7), result);
        }

        [Fact]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.Equal(Money.Dollar(1), result);
        }

        [Fact]
        public void TestEquality()
        {
            Assert.Equal(Money.Dollar(5), Money.Dollar(5));
            Assert.NotEqual(Money.Dollar(5), Money.Dollar(6));
            Assert.NotEqual((Money) Money.Franc(5), (Money) Money.Dollar(5));
        }

        [Fact]
        public void TestCurrency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency());
            Assert.Equal("CHF", Money.Franc(1).Currency());
        }
    }
}
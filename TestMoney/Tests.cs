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

        [Fact]
        public void TestReduceMoneyDifferentCurrency()
        { 
            Bank bank = new Bank();
             bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.Equal(Money.Dollar(1),result); 
        }

        [Fact]
        public void TestTupleEquality()
        {
            Assert.Equal(("abc","def"),("abc","def"));
        }

        [Fact]
        public void TestMixedAddition()
        {
            Bank bank = new Bank();
            bank .AddRate("CHF","USD",2);
            Expression fiveDollars = Money.Dollar(5);
            Expression tenFrancs = Money.Franc(10);
            Money result = bank.Reduce(fiveDollars.Plus(tenFrancs),"USD");
            Assert.Equal(10,result.Amount);
        }

        [Fact]
        public void TestSumPlusMoney()
        {
            Bank bank = new Bank();
            bank .AddRate("CHF","USD",2);
            Expression fiveDollars = Money.Dollar(5);
            Expression tenFrancs = Money.Franc(10);
            Expression sum = new Sum(fiveDollars, tenFrancs).Plus(fiveDollars);
            Money result = bank.Reduce(sum,"USD");
            Assert.Equal(15,result.Amount);
        }
        
        [Fact]
        public void TestSumTimes()
        {
            Bank bank = new Bank();
            bank .AddRate("CHF","USD",2);
            Expression fiveDollars = Money.Dollar(5);
            Expression tenFrancs = Money.Franc(10);
            Expression sum = new Sum(fiveDollars, tenFrancs).Times(2);
            Money result = bank.Reduce(sum,"USD");
            Assert.Equal(20,result.Amount);
        }

      
    }
}
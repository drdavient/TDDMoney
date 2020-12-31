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
        public void TestFrancMultiplication()
        {
            Franc five = Money.Franc(5);
            Assert.True(Money.Franc(10).Equals(five.Times(2)));
            Assert.True(Money.Franc(15).Equals(five.Times(3)));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.Dollar(5) .Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.True(Money.Franc(5) .Equals(Money.Franc (5)));
            Assert.False(Money.Franc(5).Equals(Money.Franc(6)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Fact]
        public void TestCurrency()
        {
            Assert.True("USD".Equals(Money.Dollar(1).Currency()));
            Assert.True("CHF".Equals(Money.Franc(1).Currency()));
        }
    }
}
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
            Assert.True(Money.Dollar(15).Equals( five.Times(3)));
        }
        
        [Fact]
        public void TestFrancMultiplication()
        {
            Franc five = Money.Franc(5);
            Assert.True(Money.Franc(10).Equals( five.Times(2)));
            Assert.True(Money.Franc(15).Equals( five.Times(3)));
        }

        [Fact]
        public void TestEquality()
        {
            
            Assert.Equal(Money.Dollar(5), Money.Dollar(5));
            Assert.NotEqual(Money.Dollar(5), Money.Dollar(6));
            Assert.Equal(Money.Franc(5),  Money.Franc (5));
            Assert.NotEqual(Money.Franc(5), Money.Franc(6));
            Assert.NotEqual((Money) Money.Franc(5), (Money) Money.Dollar(5));
        }

        [Fact]
        public void TestCurrency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency());
            Assert.Equal("CHF", Money.Franc(1).Currency());
        }

        [Fact]
        public void TestDifferentClassEquality()
        {
            Assert.True(new Money(10,"CHF").Equals(new Franc(10,"CHF")));
        }
        
        [Fact]
        public void TestSameCurrencyEquality()
        {
            Assert.Equal(new Money(10,"CHF").Currency(), new Franc(10,"CHF").Currency());
        }
    }
}
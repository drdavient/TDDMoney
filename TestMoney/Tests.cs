using System;
using Xunit;
using TDD_Money;

namespace TestMoney
{
    public class Tests
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.True(new Dollar(10).Equals(five.Times(2)));
            Assert.True(new Dollar(15).Equals(five.Times(3)));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5) .Equals(new Dollar (5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
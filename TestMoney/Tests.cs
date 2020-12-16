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
            Dollar result = five.Times(2);
            Assert.True(10 == result.amount);
            result = five.Times(3);
            Assert.True(15 == result.amount);
        }

        [Fact]
        public void TestEquality()
        {
            
        }
    }
}
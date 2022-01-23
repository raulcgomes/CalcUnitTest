using CalcUnitTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CalcTest
{
    public class CalcTest
    {
        Calc calc = new Calc();

        [Fact]
        public void Sum_ShouldDoCurretSumOfTwoInt()
        { 
            int result = calc.Sum(2, 3);

            result.ShouldBe(5);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(3, 3, 0)]
        [InlineData(10, 5, 5)]
        public void Sub_ShouldDoCorrectSubstrationOfTwoInt(int num1, int num2, int expected)
        {
            int result = calc.Sub(num1, num2);

            result.ShouldBe(expected);
        }

        [Fact]
        public void Mult_ShouldDoCorrectMultiplicationOfTwoInt()
        {
            int result = calc.Mult(2, 3);

            result.ShouldBe(6);
        }

        [Fact]
        public void Div_ShouldThrowExceptionDivideByZero()
        {
            Should.Throw<Exception>(() => calc.Division(6, 0));
        }

        [Fact]
        public void Div_ShouldDoCorrectDivisionOfTwoInt()
        {
            int result = (int)calc.Division(10, 2);

            result.ShouldBe(5);
        }
    }
}

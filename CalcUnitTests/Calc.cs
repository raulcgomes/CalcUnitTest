using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcUnitTests
{
    public class Calc
    {
        public int Sum(int num1, int num2)
        {
            var sum = num1 + num2;
            return sum;
        }

        public int Sub(int num1, int num2)
        {
            var sub = num1 - num2;
            return sub;
        }

        public int Mult(int num1, int num2)
        {
            var mult = num1 * num2;
            return mult;
        }

        public double Division(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new Exception("Division by 0");
            }

            var div = num1 / num2;
            return div;
        }
    }
}

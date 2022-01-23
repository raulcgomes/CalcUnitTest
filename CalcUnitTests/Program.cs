using System;

namespace CalcUnitTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int sum = (int)calc.Division(4, 2);
            System.Console.WriteLine(sum);
        }
    }
}

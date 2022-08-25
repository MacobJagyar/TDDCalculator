using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCalculator
{
    public static class Calculator
    {
        public static int Add(int a, int b) 
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (ArithmeticException e) 
            {
                Console.WriteLine("We caught a divide by 0 error!");
                return -999;
            }
        }
    }
}

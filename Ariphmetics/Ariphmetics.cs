using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariphmetics
{
    public static class Operations
    {
        public static int Sum(int a, int b) { return a + b; }

        public static int Sub(int a, int b) { return a - b; }

        public static int Mult(int a, int b) { return a * b; }

        public static int Div(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("На ноль делить нельзя!");
                throw;
            }
        }

        public static int Exp(int a, int b) { return (int)Math.Pow(a, b); }
    }
}

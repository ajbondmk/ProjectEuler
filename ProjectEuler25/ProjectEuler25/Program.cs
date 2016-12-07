using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler25
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is the first term in the Fibonacci sequence to contain 1000 digits?

            UInt64 a = 1;
            UInt64 b = 1;
            UInt64 temp;
            double max = Math.Pow(10, 999);

            while (b <= max)
            {
                temp = a + b;
                a = b;
                b = temp;
            }

            Console.WriteLine(a+b);
            Console.ReadLine();
        }
    }
}
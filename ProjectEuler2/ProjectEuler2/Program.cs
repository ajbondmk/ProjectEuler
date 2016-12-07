using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler2
{
    class Program
    {
        static void Main(string[] args)
        {
            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

            int a = 1;
            int b = 1;
            int temp;
            int sum = 0;

            while (a + b < 4000000)
            {
                temp = a + b;
                a = b;
                b = temp;
                if (b % 2 == 0) sum += b;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
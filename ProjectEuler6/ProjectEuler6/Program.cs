using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

            int sumOfSquares = 0;
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                sumOfSquares += i * i;
            }
            Console.WriteLine((sum * sum) - sumOfSquares);
            Console.ReadLine();
        }
    }
}
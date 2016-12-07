using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectEuler1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the sum of all the multiples of 3 or 5 below 1000.

            int finalSum = 0;
            for (int i = 3; i < 1000; i += 3) finalSum += i;
            for (int i = 5; i < 1000; i += 5) if (i % 3 != 0) finalSum += i;

            Console.WriteLine(finalSum);
            Console.ReadLine();
        }
    }
}
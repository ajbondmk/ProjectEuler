using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler5
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

            Class MyClass = new Class();

            for (int i = 20; i > 0; i += 20)
            {
                if (MyClass.checkIfDivisible(i, 19)) 
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
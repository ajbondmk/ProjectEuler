using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler7
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is the 10001st prime number?

            Class MyClass = new Class();
            int primeCount = 0;
            for (int i = 2; i > 0; i++)
            {
                if (MyClass.checkIfPrime(i)) primeCount += 1;
                if (primeCount == 10001)
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
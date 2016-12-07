using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler3
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is the largest prime factor of the number 600851475143?

            PrimeFactors prime = new PrimeFactors();
            prime.calculate(600851475143);
            Console.WriteLine(prime.value);
            Console.ReadLine();
        }
    }
}

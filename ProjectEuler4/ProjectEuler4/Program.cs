using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the largest palindrome made from the product of two 3-digit numbers.

            Class MyClass = new Class();
            int answer = 0;

            for (int a = 100; a < 1000; a++)
            {
                for (int b = 100; b < 1000; b++)
                {
                    int product = a * b;
                    if (product > answer)
                    {
                        if (MyClass.checkIfPalindrome(product)) answer = product;
                    }
                }
            }
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
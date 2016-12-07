using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 1; i > 0; i++)
            {
                num += i;
                int divisorCount = 0;
                if (num % 2 == 0)
                {
                    for (int x = 1; x < Math.Sqrt(num); x++)
                    {
                        if (num % x == 0)
                        {
                            if (num / x == x) divisorCount += 1;
                            else divisorCount += 2;
                        }
                    }
                }
                else
                {
                    for (int x = 1; x < Math.Sqrt(num) + 1; x += 2)
                    {
                        if (num % x == 0)
                        {
                            if (num / x == x) divisorCount += 1;
                            else divisorCount += 2;
                        }
                    }
                }
                if (divisorCount > 500)
                {
                    Console.WriteLine(num);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler14
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 answer = 0;
            Int64 highestCount = 0;
            for (Int64 i = 1; i <= 1000000; i++)
            {
                Int64 currentNum = i;
                Int64 count = 1;
                while (currentNum > 1)
                {
                    if (currentNum % 2 == 0) currentNum /= 2;
                    else currentNum = 3 * currentNum + 1;
                    count += 1;
                }
                if (count > highestCount)
                {
                    highestCount = count;
                    answer = i;
                }
            }
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler78
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt64 low = 1;
            UInt64 high = 2;
            UInt64 temp;
            UInt64 count = 2;
            while (true)
            {
                count++;
                if (count % 2 == 0)
                {
                    //Round up
                    temp = high + (low / 2) + 1;
                    if (low % 2 != 0) temp += 1;
                    low = high;
                    high = temp;
                }
                else
                {
                    //Round down
                    temp = high + (low / 2) + 1;
                    low = high;
                    high = temp;
                }
                if (high % 1000000 == 0)
                {
                    Console.WriteLine(count);
                    Console.WriteLine(high);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
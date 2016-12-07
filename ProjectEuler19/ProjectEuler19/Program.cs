using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler19
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 2;
            int sundays = 0;

            for (int y = 1901; y <= 2000; y++)
            {
                for (int m = 1; m <= 12; m++)
                {
                    switch (m)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            day = (day + 30) % 7;
                            break;
                        case 2:
                            if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
                            {
                                day = (day + 29) % 7;
                            }
                            else day = (day + 28) % 7;
                            break;
                        default:
                            day = (day + 31) % 7;
                            break;
                    }
                    if (day == 0) sundays++;
                }
            }
            Console.WriteLine(sundays);
            Console.ReadLine();
        }
    }
}
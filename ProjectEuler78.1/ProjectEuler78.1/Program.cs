using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler78._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int noOfCoins = 1; noOfCoins <= 10; noOfCoins++)
            {
                int[] groups = new int[noOfCoins];
                int solutionCount = 0;

                groups[0] = noOfCoins;
                solutionCount++;

                while (groups[0] > 1)
                {
                    for (int x = noOfCoins - 1; x >= 0; x--)
                    {
                        if (groups[x] > 1)
                        {
                            groups[x] -= 1;
                            for (int y = 1; y < noOfCoins - x; y++)
                            {
                                if (groups[x + y] < groups[x])
                                {
                                    groups[x + y] += 1;
                                    solutionCount += 1;
                                    break;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(solutionCount);
            }
            Console.ReadLine();
        }
    } 
}

// 4 1 1 goes to 3 2 1 instead of 3 3
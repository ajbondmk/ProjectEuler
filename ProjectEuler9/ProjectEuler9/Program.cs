using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler9
{
    class Program
    {
        static void Main(string[] args)
        {
            //There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.

            List<int> squares = new List<int>();
            for (int i = 2; i <= 500; i++) squares.Add(i * i);
            for (int cNum = squares.Count - 1; cNum > 1; cNum--)
            {
                for (int bNum = cNum - 1; bNum > 0; bNum--)
                {
                    int cSquare = squares[cNum];
                    int bSquare = squares[bNum];
                    if (squares.Contains(cSquare - bSquare))
                    {
                        int aSquare = cSquare - bSquare;
                        if (Math.Sqrt(aSquare) + Math.Sqrt(bSquare) + Math.Sqrt(cSquare) == 1000)
                        {
                            Console.WriteLine(Math.Sqrt(aSquare) * Math.Sqrt(bSquare) * Math.Sqrt(cSquare));
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }
        }
    }
}
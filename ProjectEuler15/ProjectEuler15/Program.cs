using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler15
{
    class Program
    {
        static void Main(string[] args)
        {
            //How many routes are there through a 20×20 grid, starting in the top left corner and only being able to move to the right and down to reach the bottom right corner?

            UInt64 top = 1;
            UInt64 bottom = 1;

            for (UInt64 t = 39; t >= 21; t -= 2) top *= t;
            for (UInt64 b = 10; b > 1; b--) bottom *= b;

            Console.WriteLine(Math.Pow(2, 10) * top / bottom);
            Console.ReadLine();
        }
    }
}
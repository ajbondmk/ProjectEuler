using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectEuler10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the sum of all the primes below two million.

            Stopwatch s1 = Stopwatch.StartNew();

            bool[] nums = new bool[2000000];
            for (int i = 0; i < nums.Length; i += 2) nums[i] = false;
            for (int i = 1; i < nums.Length; i += 2) nums[i] = true;
            nums[0] = false;
            nums[1] = false;
            double squareRoot = Math.Sqrt(nums.Length) + 1;

            for (int multiplesOf = 3; multiplesOf <= squareRoot; multiplesOf += 2)
            {
                if (nums[multiplesOf])
                {
                    for (Int64 currentMultiple = multiplesOf * multiplesOf; currentMultiple < nums.Length; currentMultiple += multiplesOf)
                    {
                        nums[currentMultiple] = false;
                    }
                }
            }

            Int64 sum = 2;
            for (int i = 3; i < nums.Length; i += 2)
            {
                if (nums[i]) sum += i;
            }

            Console.WriteLine(sum);
            s1.Stop();
            Console.WriteLine(s1.ElapsedMilliseconds + " milliseconds");
            Console.ReadLine();
        }
    }
}
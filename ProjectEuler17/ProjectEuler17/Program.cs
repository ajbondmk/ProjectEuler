using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler17
{
    class Program
    {
        static void Main(string[] args)
        {
            //If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?

            List<int> units = new List<int>();
            int one, two, three, four, five, six, seven, eight, nine;
            units.Add(one = "one".Length);
            units.Add(two = "two".Length);
            units.Add(three = "three".Length);
            units.Add(four = "four".Length);
            units.Add(five = "five".Length);
            units.Add(six = "six".Length);
            units.Add(seven = "seven".Length);
            units.Add(eight = "eight".Length);
            units.Add(nine = "nine".Length);

            List<int> teens = new List<int>();
            int ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen;
            teens.Add(ten = "ten".Length);
            teens.Add(eleven = "eleven".Length);
            teens.Add(twelve = "twelve".Length);
            teens.Add(thirteen = "thirteen".Length);
            teens.Add(fourteen = "fourteen".Length);
            teens.Add(fifteen = "fifteen".Length);
            teens.Add(sixteen = "sixteen".Length);
            teens.Add(seventeen = "seventeen".Length);
            teens.Add(eighteen = "eighteen".Length);
            teens.Add(nineteen = "nineteen".Length);

            List<int> tens = new List<int>();
            int twenty, thirty, fourty, fifty, sixty, seventy, eighty, ninety;
            tens.Add(twenty = "twenty".Length);
            tens.Add(thirty = "thirty".Length);
            tens.Add(fourty = "forty".Length);
            tens.Add(fifty = "fifty".Length);
            tens.Add(sixty = "sixty".Length);
            tens.Add(seventy = "seventy".Length);
            tens.Add(eighty = "eighty".Length);
            tens.Add(ninety = "ninety".Length);

            int hundred = "hundred".Length;
            int and = "and".Length;


            Int64 answer = 0;

            int oneToOneHundred = 0;
            foreach (int a in units) oneToOneHundred += a;
            foreach (int b in teens) oneToOneHundred += b;
            foreach (int c in tens)
            {
                oneToOneHundred += c;
                foreach (int d in units) oneToOneHundred += c + d;
            }
            answer += oneToOneHundred;
            foreach (int e in units)
            {
                answer += e + hundred;
                answer += 99 * (e + hundred + and);
                answer += oneToOneHundred;
            }
            answer += "onethousand".Length;

            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
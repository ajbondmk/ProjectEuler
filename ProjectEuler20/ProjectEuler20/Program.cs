using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the sum of the digits in the number 100!

            List<Int64> number = new List<Int64>();
            number.Add(1);

            for (Int64 num = 2; num <= 100; num++)
            {
                Int64 carry = 0;
                for (int i = 0; i < number.Count; i++)
                {
                    Int64 currentNum = number[i] * num + carry;
                    if (currentNum > 10)
                    {
                        carry = currentNum / 10;
                        currentNum -= carry * 10;
                    }
                    else carry = 0;
                    number[i] = currentNum;
                }
                while (carry > 9)
                {
                    Int64 newCarry = carry / 10;
                    number.Add(carry - newCarry * 10);
                    carry = newCarry;
                }
                number.Add(carry);
            }

            Int64 answer = 0;
            foreach (int digit in number) answer += digit;
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
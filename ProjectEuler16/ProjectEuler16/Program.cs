using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler16
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is the sum of the digits of the number 2^1000?

            List<int> listOfInts = new List<int>();
            listOfInts.Add(2);
            for (int i = 1; i < 1000; i++)
            {
                int carry = 0;
                for (int x = 0; x < listOfInts.Count; x++)
                {
                    int tempNum = listOfInts[x] * 2 + carry;
                    if (tempNum > 9)
                    {
                        tempNum -= 10;
                        carry = 1;
                    }
                    else carry = 0;
                    listOfInts[x] = tempNum;
                }
                if (carry == 1) listOfInts.Add(1);
            }

            int answer = 0;
            foreach (int y in listOfInts) answer += y;
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
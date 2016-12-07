using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler3
{
    class PrimeFactors
    {
        public Int64 value;

        public void calculate(Int64 number)
        {
            if (number % 2 == 0)
            {
                if (value < 2) value = 2;
                calculate(number / 2);
            }
            for (int i = 3; i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    if (value < i) value = i;
                    calculate(number / i);
                    break;
                }
            }
        }
    }
}
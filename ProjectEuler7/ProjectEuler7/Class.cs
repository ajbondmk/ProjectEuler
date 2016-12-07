using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler7
{
    class Class
    {
        public bool checkIfPrime(Int64 num)
        {
            if (num % 2 == 0) return false;
            for (int i = 3; i <= num/2; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler5
{
    class Class
    {
        public bool checkIfDivisible(int possibleAnswer, int factorToCheck)
        {
            if (possibleAnswer % factorToCheck == 0 && factorToCheck > 1)
            {
                factorToCheck -= 1;
                return checkIfDivisible(possibleAnswer, factorToCheck);
            }
            return (factorToCheck == 1);
        }
    }
}
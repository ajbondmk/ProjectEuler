using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler4
{
    class Class
    {
        public bool checkIfPalindrome(int num)
        {
            char[] charArray = num.ToString().ToCharArray();
            char[] charArrayReversed = (char[])charArray.Clone();
            Array.Reverse(charArrayReversed);
            return (new string(charArray) == new string(charArrayReversed));
        }
    }
}
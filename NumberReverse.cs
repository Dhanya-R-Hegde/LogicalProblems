using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblems
{
    internal class NumberReverse
    {
        int rev = 0;
        int rem = 0;

        public void revNum(int num)
        {
            while (num != 0)
            {
                rem = num % 10;
                rev = (rev * 10) + rem;
                num /= 10;
            }

            Console.WriteLine("Reversed number is " + rev);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblems
{

    internal class PerfectNumber
    {
        public int sum = 1;

        public void checkPerfectNum(int num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (i * i != num)
                        sum = sum + i + num / i;
                    else
                        sum = sum + i;
                }
            }

            if (sum == num && num!=1) Console.WriteLine("Given number is a perfect number");
            else Console.WriteLine("Given number is not a perfect number");
        }
    }
}

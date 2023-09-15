using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblems
{
    internal class PrimeNumber
    {
        public void checkPrime(int num)
        {
            int count = 0;
            if (num > 1)
            {
                for (int i = 2; i < num; i++)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("The given number is prime");
            }
            else
            {
                Console.WriteLine("The given number is not prime");
            }
        }
    }
}

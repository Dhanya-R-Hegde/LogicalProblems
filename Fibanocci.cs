using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblems
{
    internal class Fibanocci
    {
        public int num1 = 0, num2 = 1;
        public int count = 0;

        public void checkFibanocci(int n)
        {
            while (count < n)
            {
                Console.Write(num1 + " ");

                int num3 = num2 + num1;
                num1 = num2;
                num2 = num3;

                count++;
            }
        }
    }
}

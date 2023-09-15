using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblems
{
    internal class CoupenNumber
    {
        public static int num = Convert.ToInt32(Console.ReadLine()), count = 0, checkNum;
        public int[] arrayOfNum = new int[num];
        Random random = new Random();

        public void coupenNumbers()
        {

            int i = 0;

            while (i < num)
            {
                checkNum = random.Next(0, 31);
                count++;

                for (int j = 0; j < num; j++)
                {
                    if (arrayOfNum[j] != checkNum)
                        arrayOfNum[i] = checkNum;
                }

                i++;
            }

            Console.WriteLine("Coupen Numbers : ");

            for (int j = 0; j < num; j++)
            {
                Console.Write(arrayOfNum[j] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Turns taken by the program to generate all the coupen numbers is : " + count);

        }

    }
}

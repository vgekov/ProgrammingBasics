using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftOrRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < n * 2; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    sumLeft += num;
                }
                else
                {
                    sumRight += num;
                }
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine("Yes , sum = {0}", sumRight);
            }
            else
            {
                int dif = sumRight - sumLeft;
                dif = Math.Abs(dif);
                Console.WriteLine("No diff = {0}", dif);
            }
        }
    }
}

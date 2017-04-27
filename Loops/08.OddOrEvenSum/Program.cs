using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddOrEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;

            for (int i = 0; i < num; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += n;
                }
                else
                {
                    oddSum += n;
                }
             }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes sum = {0} ", evenSum);
            }
            else
            {
                Console.WriteLine("No diff = {0} ", Math.Abs(oddSum - evenSum));
            }

        }
    }
}

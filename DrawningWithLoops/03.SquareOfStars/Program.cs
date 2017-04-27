using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideOfSquare = int.Parse(Console.ReadLine());

            for (int i = 0; i < sideOfSquare; i++)
            {
                for (int j = 0; j < sideOfSquare; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

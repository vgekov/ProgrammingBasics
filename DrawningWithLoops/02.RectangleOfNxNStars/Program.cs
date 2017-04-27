using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RectangleOfNxNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideOfSquare = int.Parse(Console.ReadLine());

            for (int i = 0; i < sideOfSquare; i++)
            {
                Console.WriteLine(new string ('*' , sideOfSquare));
            }
        }
    }
}

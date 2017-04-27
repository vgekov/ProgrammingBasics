using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var sideA = Math.Abs(x2 - x1);
            var sideB = Math.Abs(y2 - y1);
            var area = sideA * sideB;
            var perimeter = 2 * (sideA + sideB);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);



        }
    }
}

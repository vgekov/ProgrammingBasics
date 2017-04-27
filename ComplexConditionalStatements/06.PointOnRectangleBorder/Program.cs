using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var xOfPoint = double.Parse(Console.ReadLine());
            var yOfPoint = double.Parse(Console.ReadLine());

            var isOnTopBorder = xOfPoint >= x1 && xOfPoint <= x2 && yOfPoint == y1;
            var inOnBottomBorder = xOfPoint >= x1 && xOfPoint <= x2 && yOfPoint == y2;
            var isOnLeftBorder = yOfPoint >= y1 && yOfPoint <= y2 && xOfPoint == x1;
            var isOnRightBorder = yOfPoint >= y1 && yOfPoint <= y2 && xOfPoint == x2;

            if (!(isOnRightBorder || isOnLeftBorder|| isOnTopBorder || inOnBottomBorder))
            {
                Console.WriteLine("Inside / Outside");
            }
            else
            {
                Console.WriteLine("Border");
            }
        }
    }
}

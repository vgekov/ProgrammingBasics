using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double cows = double.Parse(Console.ReadLine());
            var area = rows * cows;
            var price = -1;
            if (projection == "Premiere")
            {
                Console.WriteLine("{0:f2}",area * 12.00);
            }
           else  if (projection == "Normal")
            {
                Console.WriteLine("{0:f2}", area * 7.50);
            }
            else if (projection == "Discount")
            {
                Console.WriteLine("{0:f2}", area * 5.00);
            }


        }
    }
}

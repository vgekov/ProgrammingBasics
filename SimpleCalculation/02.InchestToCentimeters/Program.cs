using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InchestToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inches = double.Parse(Console.ReadLine());
            var centimeteres = inches * 2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(centimeteres);
        }
    }
}

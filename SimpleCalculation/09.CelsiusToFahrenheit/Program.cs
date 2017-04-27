using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var fahren = (celsius * 9) / 5 + 32;
            Console.WriteLine(fahren);
        }
    }
}

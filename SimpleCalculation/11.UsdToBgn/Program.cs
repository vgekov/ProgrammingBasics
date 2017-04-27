using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            var dollars = double.Parse(Console.ReadLine());
            var bgn = dollars * 1.79549;
            Console.WriteLine("{0} BGN", bgn);
        }
    }
}

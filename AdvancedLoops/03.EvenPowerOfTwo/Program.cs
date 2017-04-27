using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EvenPowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var result = 1;
            for (int i = 0; i <= num; i+=2)
            {
                Console.WriteLine(result);
                result *= 2 * 2;
                
            }
        }
    }
}

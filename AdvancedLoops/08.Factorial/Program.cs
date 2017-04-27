using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int product = 1;
            int counter = 1;
            do
            {

                product = product * counter;
                counter++;

            } while (counter <= n);
            Console.WriteLine(product);
        }
    }
}

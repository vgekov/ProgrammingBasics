using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            while (n > 0)
            {
                int rem = n % 10;
                sum += rem;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}

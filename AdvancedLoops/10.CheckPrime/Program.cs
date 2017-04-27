using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int i = 2;

            while (true)
            {
                if (n % i != 0)
                {
                    Console.WriteLine("Not Prime");
                    break;
                }

                else 
                 {
                    Console.WriteLine("Prime");
                    break;
                }
            }
        }
    }
}

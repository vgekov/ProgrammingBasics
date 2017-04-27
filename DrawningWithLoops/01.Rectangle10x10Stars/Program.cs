using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rectangle10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var row = 0; row < 10; row++)
            {
                
                for (var col = 0; col < 10; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            
        }
    }
}

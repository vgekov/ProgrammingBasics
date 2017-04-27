using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequence = int.Parse(Console.ReadLine());
            int fibonacciFirst = 1;
            int fibonacciSecond = 1;

            for (int count = 1; count <= sequence; count++)
            {
                int fibonacciThird = fibonacciFirst + fibonacciSecond;
                fibonacciFirst = fibonacciSecond;
                fibonacciSecond = fibonacciThird;
            }
            Console.WriteLine(fibonacciFirst);
        }
    }
}

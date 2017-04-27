using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixNumber = int.Parse(Console.ReadLine());
            int number = 0;

            for (int cols = 0; cols < matrixNumber; cols++)
            {
                for (int rows = 0; rows < matrixNumber; rows++)
                {
                    number = rows + cols + 1;
                    if (number > matrixNumber)
                    {
                        number = 2 * matrixNumber - number;
                    }
                    Console.Write("{0} ", number);
                }
                Console.WriteLine();
            }
        }
    }
}

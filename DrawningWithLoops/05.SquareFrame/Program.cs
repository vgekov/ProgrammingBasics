using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            #region first line
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
            #endregion

            #region middle line

            for (int row = 0; row < n-2; row++)
            {
                Console.Write("| ");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }
            
            

            #endregion 

            #region last line
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
            #endregion


        }
    }
}

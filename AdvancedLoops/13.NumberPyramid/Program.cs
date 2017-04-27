using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int pyramidNum = int.Parse(Console.ReadLine());
            int num = 0;

            for (int cols  = 0; cols  < pyramidNum; cols ++)
            {
                for (int rows = 0; rows <= cols; rows++)
                {
                    num++;
                    if (num > pyramidNum)
                    {
                        return;
                    }
                    Console.Write("{0} " , num);
                }
                Console.WriteLine();
            }
        }
    }
}

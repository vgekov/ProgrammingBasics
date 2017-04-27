using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = int.Parse(Console.ReadLine());
            double maxEven = double.MinValue;
            double minEven = double.MaxValue;
            double maxOdd = double.MinValue;
            double minOdd = double.MaxValue;
            double sumEven = 0;
            double sumOdd = 0;

            if (num != 1 && num != 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    double number = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        sumEven += number;
                        if (number > maxEven)
                        {
                            maxEven = number;
                        }
                        if (number < minEven)
                        {
                            minEven = number;
                        }
                    }
                    else if (i % 2 != 0)
                    {
                        sumOdd += number;
                        if (number > maxOdd)
                        {
                            maxOdd = number;
                        }
                        if (number < minOdd)
                        {
                            minOdd = number;
                        }
                    }
                }
                Console.WriteLine("Oddsum = {0}", sumOdd);
                Console.WriteLine("Oddmin = {0}", minOdd);
                Console.WriteLine("Oddmax = {0}", maxOdd);
                Console.WriteLine("Evensum = {0}", sumEven);
                Console.WriteLine("Evenmin = {0}", minEven);
                Console.WriteLine("Evenmax = {0}", maxEven);
            }
            else if (num == 0)
            {
                Console.WriteLine("Oddsum = 0");
                Console.WriteLine("Oddmin = No");
                Console.WriteLine("Oddmax = No");
                Console.WriteLine("Evensum = 0");
                Console.WriteLine("Evenmin = No");
                Console.WriteLine("Evenmax = No");
            }
            else if (num == 1)
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("Oddsum = {0}", number);
                Console.WriteLine("Oddmin = {0}", number);
                Console.WriteLine("Oddmax = {0}", number);
                Console.WriteLine("Evensum = 0");
                Console.WriteLine("Evenmin = No");
                Console.WriteLine("Evenmax = No");
            }
        }
    }
}
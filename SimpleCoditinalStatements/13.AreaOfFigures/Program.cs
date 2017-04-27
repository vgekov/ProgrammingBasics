using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            figure = figure.ToLower();


            if (figure == "square")
            {
                double num = double.Parse(Console.ReadLine());
                num = num * num;
                Console.WriteLine("{0:F3}", num);
            }
            else if (figure == "rectangle")
            {
                double num = double.Parse(Console.ReadLine());
                double num1 = double.Parse(Console.ReadLine());
                double sum = num * num1;
                Console.WriteLine("{0:F3}", sum);
            }
            else if (figure == "circle")
            {
                double num = double.Parse(Console.ReadLine());
                num = (num * 3.14159) * num;
                Console.WriteLine("{0:F3}" , num);
            }
            else if (figure == "triangle")
            {
                double num = double.Parse(Console.ReadLine());
                double num1 = double.Parse(Console.ReadLine());
                double sum = (num * num1) / 2;
                Console.WriteLine("{0:F3}" , sum);

            }




        }
    }
}

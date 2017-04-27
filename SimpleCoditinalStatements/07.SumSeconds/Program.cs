using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int min = (num1 + num2 + num3) / 60;
            int sec = (num1 + num2 + num3) % 60;
            Console.WriteLine("{0}:{1:00}" , min , sec);
        }
    }
}

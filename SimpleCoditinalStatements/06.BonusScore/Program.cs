﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var bonus = 0.0;
            if (num <= 100)
            {
                bonus = bonus + 5;
            }
            else if (num <= 1000)
            {
                bonus = bonus + num * 0.2;
            }
            else
            {
                bonus = bonus + num * 0.1;
            }
            if (num % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (num % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);




        }
    }
}

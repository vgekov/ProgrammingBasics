﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write(new string('*', row));
                Console.Write(" | ");
                Console.Write(new string('*', row));
                Console.WriteLine(new string(' ', n - row));
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 0; i <=  n; i++)
            {
                Console.WriteLine(result);
                result = result * 2;
            }
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (product == "coffee") Console.WriteLine(quantity * 0.50);
                if (product == "water") Console.WriteLine(quantity * 0.80);
                if (product == "beer") Console.WriteLine(quantity * 1.20);
                if (product == "sweets") Console.WriteLine(quantity * 1.45);
                if (product == "peanuts") Console.WriteLine(quantity * 1.60);
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee") Console.WriteLine(quantity * 0.40);
                if (product == "water") Console.WriteLine(quantity * 0.70);
                if (product == "beer") Console.WriteLine(quantity * 1.15);
                if (product == "sweets") Console.WriteLine(quantity * 1.30);
                if (product == "peanuts") Console.WriteLine(quantity * 1.50);
            }
            if (city == "Varna")
            {
                if (product == "coffee") Console.WriteLine(quantity * 0.45);
                if (product == "water") Console.WriteLine(quantity * 0.70);
                if (product == "beer") Console.WriteLine(quantity * 1.10);
                if (product == "sweets") Console.WriteLine(quantity * 1.35);
                if (product == "peanuts") Console.WriteLine(quantity * 1.55);
            }
        }
    }
}


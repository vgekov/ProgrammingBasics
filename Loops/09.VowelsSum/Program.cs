﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                var letter = word[i];
                if (letter == 'a') sum += 1;
                else if (letter == 'e') sum += 2;
                else if (letter == 'i') sum += 3;
                else if (letter == 'o') sum += 4;
                else if (letter == 'u') sum += 5;
            }

            Console.WriteLine(sum);
        }
    }
}

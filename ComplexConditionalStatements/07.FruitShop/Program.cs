using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            
            var price = -1.0;
            
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana") price = 2.50;
                if (fruit == "apple") price = 1.20;
                if (fruit == "orange") price = 0.85;
                if (fruit == "grapefrut") price = 1.45;
                if (fruit == "kiwi") price = 2.70;
                if (fruit == "pineapple") price = 5.50;
                if (fruit == "grape") price = 3.85;
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana") price = 2.70;
                if (fruit == "apple") price = 1.25;
                if (fruit == "orange") price = 0.90;
                if (fruit == "grapefrut") price = 1.60;
                if (fruit == "kiwi") price = 3.00;
                if (fruit == "pineapple") price = 5.60;
                if (fruit == "grape") price = 4.20;
            }
            if (price >= 0)
            {
                Console.WriteLine("{0:f2}", price * quantity);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

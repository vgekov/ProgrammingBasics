using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var firstCurrency = Console.ReadLine();
            var secondCurrency = Console.ReadLine();

            var firstRate = 0.0;
            var secondRate = 0.0;
            if (firstCurrency == "BGN")
            {
                firstRate = 1.0;
            }
            else if (firstCurrency == "USD")
            {
                firstRate = 1.79549;
            }
            else if (firstCurrency == "EUR")
            {
                firstRate = 1.95583;
            }
            else if (firstCurrency == "GBP")
            {
                firstRate = 2.53405;
            }
            if (secondCurrency == "BGN")
            {
                secondRate = 1.0;
            }
            else if (secondCurrency == "USD")
            {
                secondRate = 1.79549;
            }
            else if (secondCurrency == "EUR")
            {
                secondRate = 1.95583;
            }
            else if (secondCurrency == "GBP")
            {
                secondRate = 2.53405;
            }
            var sum = num * firstRate / secondRate;

            Console.WriteLine(Math.Round(sum, 2) + " " + secondCurrency);




        }
    }
}

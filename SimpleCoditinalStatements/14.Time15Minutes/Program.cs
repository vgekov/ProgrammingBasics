using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = hours * 60 + minutes + 15;
            hours = minutes / 60;
            minutes = minutes % 60;
            if (hours == 24)
            {
                hours = 0;
            }

            Console.WriteLine("{0}:{1:D2}", hours , minutes);
        }
    }
}

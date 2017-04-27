using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VolleyBall
{
    class Program
    {
        static void Main(string[] args)
      {
            var yearType = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            var weekends =  (48 - h);
            var sundayGames = weekends * (3.0 / 4); // 34.5
            var holidayGames = p * (2.0 / 3) ; //3.333
            var normalYear = sundayGames + holidayGames + h;
            var leapYear = (normalYear * 0.15 ) + normalYear;
            if (yearType == "normal")
            {
                Console.WriteLine(Math.Floor(normalYear));
            }
            else if (yearType == "leap")
            {
                Console.WriteLine(Math.Floor(leapYear));
            }

        }
    }
}

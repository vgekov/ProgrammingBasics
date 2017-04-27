using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string ftm = "dd-MM-yyyy";
            string value = Console.ReadLine();
            DateTime userBirthDay = DateTime.ParseExact(value, ftm, null);
            Console.WriteLine(userBirthDay.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}

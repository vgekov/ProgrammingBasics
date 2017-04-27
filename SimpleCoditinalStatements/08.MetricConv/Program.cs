using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MetricConv
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = double.Parse(Console.ReadLine());
            var inputMetric = Console.ReadLine();
            var outputMetric = Console.ReadLine();
            var intermediateMeters = 0.0;
            var finalNumber = 0.0;

            #region Input

            if (inputMetric == "mm")
            {
                intermediateMeters = inputNumber / 1000;
            }
            else if (inputMetric == "cm")
            {
                intermediateMeters = inputNumber / 100;
            }
            else if (inputMetric == "mi")
            {
                intermediateMeters = inputNumber / 0.000621371192;
            }
            else if (inputMetric == "in")
            {
                intermediateMeters = inputNumber / 39.3700787;
            }
            else if (inputMetric == "km")
            {
                intermediateMeters = inputNumber / 0.001;
            }
            else if (inputMetric == "ft")
            {
                intermediateMeters = inputNumber / 3.2808399;
            }
            else if (inputMetric == "yd")
            {
                intermediateMeters = inputNumber / 1.0936133;
            }else if (inputMetric == "m")
            {
                intermediateMeters = inputNumber;
            }


            #endregion


            #region Output

            if (outputMetric == "mm")
            {
                finalNumber = intermediateMeters * 1000;
            }
            else if (outputMetric == "cm")
            {
                finalNumber = intermediateMeters * 100;
            }
            else if (outputMetric == "mi")
            {
                finalNumber = intermediateMeters * 0.000621371192;
            }
            else if (outputMetric == "in")
            {
                finalNumber = intermediateMeters * 39.3700787;
            }
            else if (outputMetric == "km")
            {
                finalNumber = intermediateMeters * 0.001;
            }
            else if (outputMetric == "ft")
            {
                finalNumber = intermediateMeters * 3.2808399;
            }
            else if (outputMetric == "yd")
            {
                finalNumber = intermediateMeters * 1.0936133;
            }else if (outputMetric == "m")
            {
                finalNumber = intermediateMeters;
            }
            #endregion
            Console.WriteLine($"{finalNumber} {outputMetric}");
        }
    }
}

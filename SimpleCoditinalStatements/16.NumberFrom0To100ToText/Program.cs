using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumberFrom0To100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                int firstNumber = n / 10;
                int secondNumber = 0;
                int bothNumbers = n;
                if (n >= 0 && n <= 10)
                {
                    secondNumber = n;
                }
                else if (n >= 20)
                {
                    secondNumber = n % 10;
                }
                string firstWord = "";
                string secondWord = "";
                string bothWords = "";


                #region firstNumber
                if (firstNumber >= 20 && firstNumber >= 29 )
                {
                    firstWord = "twenty";
                }
                else if (firstNumber >= 30 && firstNumber <= 39)
                {
                    firstWord = "thirty";
                }
                else if (firstNumber == 40)
                {
                    firstWord = "fourty";
                }
                else if (firstNumber == 50)
                {
                    firstWord = "fifty";
                }
                else if (firstNumber == 60)
                {
                    firstWord = "sixty";
                }
                else if (firstNumber == 70)
                {
                    firstWord = "seventy";
                }
                else if (firstNumber == 80)
                {
                    firstWord = "eighty";
                }
                else if (firstNumber == 90)
                {
                    firstWord = "ninety";
                }
                else if (firstNumber == 100)
                {
                    firstWord = "one hundred";
                }

                #endregion

                #region secondNumber

                if (secondNumber == 0)
                {
                    secondWord = "zero";
                }
                else if (secondNumber == 1)
                {
                    secondWord = "one";
                }
                else if (secondNumber == 2)
                {
                    secondWord = "two";
                }
                else if (secondNumber == 3)
                {
                    secondWord = "three";
                }
                else if (secondNumber == 4)
                {
                    secondWord = "four";
                }
                else if (secondNumber == 5)
                {
                    secondWord = "five";
                }
                else if (secondNumber == 6)
                {
                    secondWord = "six";
                }
                else if (secondNumber == 7)
                {
                    secondWord = "seven";
                }
                else if (secondNumber == 8)
                {
                    secondWord = "eight";
                }
                else if (secondNumber == 9)
                {
                    secondWord = "nine";
                }
                #endregion

                #region bothNumbers
                if (bothNumbers == 10)
                {
                    bothWords = "ten";
                }
                else if (bothNumbers == 11)
                {
                    bothWords = "eleven";
                }
                else if (bothNumbers == 12)
                {
                    bothWords = "twelve";
                }
                else if (bothNumbers == 13)
                {
                    bothWords = "thirteen";
                }
                else if (bothNumbers == 14)
                {
                    bothWords = "fourteen";
                }
                else if (bothNumbers == 15)
                {
                    bothWords = "fifteen";
                }
                else if (bothNumbers == 16)
                {
                    bothWords = "sixteen";
                }
                else if (bothNumbers == 17)
                {
                    bothWords = "seventeen";
                }
                else if (bothNumbers == 18)
                {
                    bothWords = "eighteen";
                }
                else if (bothNumbers == 19)
                {
                    bothWords = "nineteen";
                }
                #endregion
  if (n % 10 == 0 && n != 0)
        {
            secondWord = "";
        }

        if (n >= 0 && n < 10)
        {
            Console.WriteLine(secondWord);
        }

        else if (n >= 10 && n <= 19)
        {
            Console.WriteLine(bothWords);
        }
        else if (n >= 20 && n <= 100)
        {
            if (n % 10 == 0)
            {
                Console.WriteLine(firstWord);
            }
            else
            {
                Console.WriteLine(firstWord + " " + secondWord);
            }

        }
        else
        {
            Console.WriteLine("invalid number");
        }

            }

        }
    }
}


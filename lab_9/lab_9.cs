using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab_9
{
    class lab_9
    {
        public static int GetFirstNumber(int num1)
        {
            if (num1 >= 5 || num1 <= 0)
            {
                throw new Exception("please enter a number between 1 and 4");

            }
            else
                return num1;
        }
        public static string GetFoodHometown(string word)
        {
            if (word != "hometown" || word != "food")
            {
                throw new Exception("Please enter hometown or food");
            }
            else
                return word;
        }

        public static string CheckChar(string word)
        {
                if (Regex.IsMatch(word, @"^([A - Za - z]) *"))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                return word;
        }
    }
}

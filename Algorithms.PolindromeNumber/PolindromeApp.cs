using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Algorithms.PolindromeNumber
{
    public static class PolindromeApp
    {
        public static void TakeTheNumber(int number)
        {
            string numberStr = number.ToString();
            string[] numberArray = numberStr.Select(x => x.ToString()).ToArray();
            var reversingNumber = numberArray.Reverse();
            StringBuilder builderNumber = new StringBuilder();
            foreach (var item in reversingNumber)
            {
                builderNumber.Append(item);
            }
            string reversedNumber = builderNumber.ToString();
            if(IsPolindromNumber(numberStr, reversedNumber))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{number} Is Polindrom");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{number} Not Polindrom");
            }

            
        }

        
        public static bool IsPolindromNumber(string number, string reversedNumber)
        {
            return number.Equals(reversedNumber);
            
        }
    }
}

using System;

namespace Algorithms.PolindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number");
            string number = Console.ReadLine();
            PolindromeApp.TakeTheNumber(Convert.ToInt32(number));
            Console.ReadLine();
        }
    }
}

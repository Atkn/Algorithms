using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Linq;
namespace Algorithms.Bracket
{
    public static class BracketApp
    {

        public static void TakeArrayValue(string strArray)
        {
            if (!string.IsNullOrEmpty(strArray))
            {
                string[] strToArray = strArray.Select(x => x.ToString()).ToArray();
                string firstBracket = "";
                string lastBracket = firstBracket;
                for (int i = 0; i < strToArray.Length; i++)
                {
                    if (string.IsNullOrEmpty(firstBracket))
                    {
                        firstBracket = strToArray[i];
                    }
                    if (i + 1 == strToArray.Length)
                    {
                        lastBracket = strToArray[i];
                    }
                }
                ConsoleOperation(firstBracket, lastBracket);
            }
            else
            {
                Console.WriteLine("Girdi Algılanmadı!");
            }
            
        }

        public static string FindLastBracket(string firstBracket)
        {
            switch (firstBracket)
            {
                case "{":
                    return "}";
                case "[":
                    return "]";
                case "(":
                    return ")";
                default:
                    break;
            }
            return "Parantez algılanamadı!";
        }

        public static bool CheckBracket(string bracketValue, string foundBracket)
        {
            return bracketValue.Equals(foundBracket);
        }

        public static void ConsoleOperation(string firstBracket, string lastBracket)
        {
            Console.WriteLine($"Dizi Başlangıç Parantezi: {firstBracket}");
            Console.WriteLine($"Dizi Bitiş Parantezi: {lastBracket}");

            var findLastBracket = FindLastBracket(firstBracket);
            Console.WriteLine($"Olması gereken: {findLastBracket}");
            Console.WriteLine("Karşılaştırılıyor...");
            if (CheckBracket(lastBracket, findLastBracket))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bu dizi doğru bir dizidir!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bu dizi doğru bir dizi değildir!");
            }
        }
    }
}

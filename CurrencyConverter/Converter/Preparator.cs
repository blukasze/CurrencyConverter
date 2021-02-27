using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CurrencyConverter.Converter
{
    class Preparator
    {
        public static string PrepareInput(string rawInput)
        {
            string result = rawInput.Replace(".", ",");
            result = Regex.Replace(result, @"\s+", "");
            result = AddZero(result);
            return result;
        }

        private static string AddZero(string rawInput)
        {
            if (NeedAddition(rawInput))
            {
                return rawInput + "0";
            }
            else return rawInput;
        }

        private static bool NeedAddition(string rawInput)
        {
            var lastTwoDigits = GetLast(rawInput, 2);
            if (lastTwoDigits.Length == 2 && lastTwoDigits.StartsWith(","))
            {
                return true;
            } return false;
        }

        private static string GetLast(string source, int tail_length)
        {
            if (tail_length >= source.Length)
                return source;
            return source.Substring(source.Length - tail_length);
        }
    }
}

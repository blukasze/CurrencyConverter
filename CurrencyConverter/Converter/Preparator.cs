using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CurrencyConverter.Converter
{
    class Preparator : IPreparator
    {
        public string PrepareInput(string rawInput)
        {
            string result = rawInput.Replace(".", ",");
            result = Regex.Replace(result, @"\s+", "");
            result = AddZeroToCents(result);
            if (!(result.Length == 0))
            {
                result = TrimZeroes(result);
            }
            return result;
        }

        private string TrimZeroes(string rawInput)
        {
            rawInput = rawInput.TrimStart('0');
            if (rawInput.StartsWith(",") || rawInput.StartsWith(".") || rawInput.Length == 0)
            {
                rawInput = rawInput.Insert(0, "0");
            }
            return rawInput;
        }

        private string AddZeroToCents(string rawInput)
        {
            if (NeedAddition(rawInput))
            {
                return rawInput + "0";
            }
            else return rawInput;
        }

        private bool NeedAddition(string rawInput)
        {
            var lastTwoDigits = GetLast(rawInput, 2);
            if (lastTwoDigits.Length == 2 && lastTwoDigits.StartsWith(","))
            {
                return true;
            } return false;
        }

        private string GetLast(string source, int tail_length)
        {
            if (tail_length >= source.Length)
                return source;
            return source.Substring(source.Length - tail_length);
        }
    }
}

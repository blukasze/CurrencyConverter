using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Converter
{
    class Preparator
    {
        public static string PrepareInput(string rawInput)
        {
            string result = rawInput.Replace(".", ",");
            result = result.Trim();
            result = result.Replace(" ", "");
            return result;
        }
    }
}

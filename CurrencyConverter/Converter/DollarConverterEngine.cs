using CurrencyConverter.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Converter
{
    class DollarConverterEngine : ICurrencyConverter
    {
        public IValidator Validator { get; set; }
        public IPreparator Preparator { get; set; }

        public string ConvertToWordFormat(string input)
        {
            var preparedInput = Preparator.PrepareInput(input);
            var result = Validator.Validate(preparedInput);
            if (! result.isValid)
            {
                return result.Message;
            }

            List<string> numbers = SplitInParts(preparedInput, 3).ToList();

            foreach(string number in numbers)
            {
                result.Message += number;
            }
            return result.Message;
        }

        private string ConvertPart(string part)
        {

            return "";
        }

        private List<String> SplitInParts(string s, int partLength)
        {
            List<string> result = new List<string>();
            List<string> listOfReversed = new List<string>();
            var reversed = Reverse(s);
            for (var i = 0; i < reversed.Length; i += partLength)
                listOfReversed.Add( reversed.Substring(i, Math.Min(partLength, s.Length - i)));

            foreach(string part in listOfReversed)
            {
                result.Add(Reverse(part));
            }
            return result;
        }

        private string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

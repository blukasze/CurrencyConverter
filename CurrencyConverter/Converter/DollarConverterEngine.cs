﻿using CurrencyConverter.Validator;
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
            if (!result.isValid)
            {
                return result.Message;
            }

            List<string> numbers = SplitInParts(preparedInput, 3).ToList();

            int amountOfParts = numbers.Count;
            if (ContainCents(input))
            {
                amountOfParts -= 1;
            }

            foreach (string number in numbers)
            {
                result.Message += ConvertPart(number) + ConvertionTable.OrderOfMagniture(amountOfParts);
                amountOfParts -= 1;
            }
            return result.Message.Replace("  ", " ");
        }

        private string ConvertPart(string part)
        {
            var result = "";
            if (part.Length == 3)
            {
                if (part.Contains(","))
                {
                    if (part.Equals(".01"))
                    {
                        result += " and one cent";
                    }
                    else
                    {
                        result += " and " + ConvertDouble(part.Substring(1, 2)) + " cents";
                    }
                } else
                {
                    result += ConvertionTable.Single(part[0]) + " hundred ";
                    result += ConvertDouble(part.Substring(1, 2));
                }
            }
            if (part.Length == 2)
            {
                result += ConvertDouble(part);
            }
            if (part.Length == 1)
            {
                result += ConvertionTable.Single(part[0]);
            }
            return result;
        }

        private string ConvertDouble(string part)
        {
            var deciderInt = int.Parse(part);
            if (deciderInt < 20)
            {
                return ConvertionTable.Double(part);
            }
            if (deciderInt % 10 == 0)
            {
                return ConvertionTable.Double(part[0].ToString());
            }
            return ConvertionTable.Double(part[0].ToString()) + "-" + ConvertionTable.Single(part[1]);
        }

        private IEnumerable<String> SplitInParts(string s, int partLength)
        {
            List<string> result = new List<string>();
            List<string> listOfReversed = new List<string>();
            var reversed = Reverse(s);
            for (var i = 0; i < reversed.Length; i += partLength)
                listOfReversed.Add(reversed.Substring(i, Math.Min(partLength, s.Length - i)));

            foreach (string part in listOfReversed)
            {
                result.Add(Reverse(part));
            }
            for (int i = result.Count - 1; i >= 0; i--)
            {
                yield return result[i];
            }
        }

        private string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private bool ContainCents(string input)
        {
            return input.Contains(",");
        }
    }
}

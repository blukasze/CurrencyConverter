using CurrencyConverter.Validator;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverter
{
    class ValidatorEngine
    {
        public static Valid IsValid(string input)
        {
            return new Valid() {
                isValid = true,
                Message = "" };
        }
    }
}

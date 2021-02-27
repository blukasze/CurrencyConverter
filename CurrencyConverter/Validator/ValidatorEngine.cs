using CurrencyConverter.Validator;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverter
{
    class ValidatorEngine : IValidator
    {
        public Valid Validate(string input)
        {
            var number = isValidNumber(input);
            if (!number.isValid)
            {
                return number;
            }
            else
            {
                var cents = isNumberOfCentsCorrect(input);
                if (!cents.isValid)
                {
                    return cents;
                }
            }
            return new Valid()
            {
                isValid = true,
                Message = ""
            };
        }

        private Valid isNumberOfCentsCorrect(string input)
        {
            var chunks = input.Split(',');
            if (chunks.Length > 2)
            {
                return new Valid()
                {
                    isValid = false,
                    Message = "Incorrect input, too many separators. Please, provide valid input"
                };
            }
            if (chunks.Length == 1)
            {
                return new Valid()
                {
                    isValid = true,
                    Message = ""
                };
            }
            var cents = chunks[1];
            if (cents.Length != 2)
            {
                return new Valid()
                {
                    isValid = false,
                    Message = "Too many cents. Please provide a value with cents from 0 to 99"
                };
            }
            return new Valid()
            {
                isValid = true,
                Message = ""
            };
        }

        private Valid isValidNumber(string input)
        {
            var isValid = false;
            var message = "";
            double inputAsNumber;

            try
            {
                inputAsNumber = double.Parse(input.Replace(",","."));
                if (inputAsNumber >= 1000000000)
                {
                    message = "Number is too big, please provide a number less than 1 000 000 000";
                } else
                {
                    isValid = true;
                }
                    

            }
            catch (ArgumentNullException ex)
            {
                message = "Empty value, please provide a valid number";

            }
            catch (FormatException ex)
            {
                message = "Not a number, please provide a valid number";
            }
            catch (OverflowException ex)
            {
                message = "Number is too big, please provide a number less than 1 000 000 000";
            }

            return new Valid()
            {
                isValid = isValid,
                Message = message
            };
        }
    }
}

using CurrencyConverter.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            var preparator = new Preparator();
            var validator = new ValidatorEngine();
            var converter = new DollarConverterEngine()
            {
                Preparator = preparator,
                Validator = validator
            };

            Console.WriteLine("Please, type in the amount you want converted");
            Console.WriteLine("The number should be less than 1 000 000 000 dollars");
            Console.WriteLine("Type 'q' to quit");
            while (!input.Equals("q"))
            {
                input = Console.ReadLine();
                var outputMessage = converter.ConvertToWordFormat(input);
                Console.WriteLine("Converted number is: " + outputMessage);
            }
        }
    }
}

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
        public string RawInput { get; set; }

        public string ConvertToWordFormat(string input)
        {
            throw new NotImplementedException();
        }
    }
}

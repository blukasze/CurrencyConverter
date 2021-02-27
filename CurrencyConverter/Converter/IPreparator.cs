using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Converter
{
    interface IPreparator
    {
        string PrepareInput(string input);
    }
}

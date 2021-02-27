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
            Console.WriteLine("Please, type in the amount you want converted");
            Console.WriteLine("The number should be less than 1 000 000 000 dollars");
            var number = Console.ReadLine();

            Console.WriteLine("Converted number is: ");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}

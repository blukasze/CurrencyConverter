using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Converter
{
    class ConvertionTable
    {
        public static string OrderOfMagniture(int n)
        {
            switch (n)
            {
                case 3:
                    return " million ";
                case 2:
                    return " thousand ";
                case 1:
                    return " dollars";
                case 0:
                    return "";
                default:
                    return "incorect value ";
            }
        }
        public static string Single(char n)
        {
            int i = int.Parse(n.ToString());
            switch (i)
            {
                case 0:
                    return "zero";
                case 1:
                    {
                        return "one";
                    }
                case 2:
                    {
                        return "two";
                    }
                case 3:
                    {
                        return "three";
                    }
                case 4:
                    {
                        return "four";
                    }
                case 5:
                    {
                        return "five";
                    }
                case 6:
                    {
                        return "six";
                    }
                case 7:
                    {
                        return "seven";
                    }
                case 8:
                    {
                        return "eight";
                    }
                case 9:
                    {
                        return "nine";
                    }
                default: return "invalid number";
            }
        }

        public static string Double(string n)
        {
            int i = int.Parse(n);
            switch (i)
            {
                case 0:
                    return "";
                case 10:
                    {
                        return "ten";
                    }
                case 11:
                    {
                        return "eleven";
                    }
                case 12:
                    {
                        return "twelve";
                    }
                case 13:
                    {
                        return "thirteen";
                    }
                case 14:
                    {
                        return "fourteen";
                    }
                case 15:
                    {
                        return "fifteen";
                    }
                case 16:
                    {
                        return "sixteen";
                    }
                case 17:
                    {
                        return "seventeen";
                    }
                case 18:
                    {
                        return "eighteen";
                    }
                case 19:
                    {
                        return "nineteen";
                    }
                case 2:
                    {
                        return "twenty";
                    }
                case 3:
                    {
                        return "thirty";
                    }
                case 4:
                    {
                        return "forty";
                    }
                case 5:
                    {
                        return "fifty";
                    }
                case 6:
                    {
                        return "sixty";
                    }
                case 7:
                    {
                        return "seventy";
                    }
                case 8:
                    {
                        return "eighty";
                    }
                case 9:
                    {
                        return "ninety";
                    }
                default:
                    {
                        return "incorrect number";
                    }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project
{
    public static class BookPropertyValidator
    {
        public static bool ValidatePrice(string price)
        {
            price = price.Replace('.', ',');
            Regex regex = new Regex("^\\d+(\\,\\d+)?$");
            return regex.IsMatch(price);
        }
    }
}

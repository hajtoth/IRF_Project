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

        public static bool ValidateDate(string publish_date)
        {
            Regex regex = new Regex("^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\\d\\d$");
            return regex.IsMatch(publish_date);

        }


    }
}

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
        public static bool ValidateAuthor(string author)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");
            return regex.IsMatch(author);
        }

        public static bool ValidateTitle(string title)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");
            return regex.IsMatch(title);
        }

        public static bool ValidateGenre(string genre)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");
            return regex.IsMatch(genre);
        }


    }
}

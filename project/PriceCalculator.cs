using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public static class PriceCalculator
    {
        public static double CalculateSalePrice(double price, int saleCode)
        {
            if (saleCode == 6)
            {
                price *= 0.9;
            }
            else if (saleCode == 7)
            {
                price *= 0.8;
            }
            else if (saleCode == 8)
            {
                price *= 0.7;
            }
            else if (saleCode == 9)
            {
                price *= 0.6;
            }
            else if (saleCode == 10)
            {
                price *= 0.5;
            }

            return Math.Round(price, 2, MidpointRounding.AwayFromZero);
        }
        
    }
}

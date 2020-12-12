using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using project;

namespace CatalogTest
{
    [TestFixture]
    public class PriceCalculatorTest
    {
        [TestCase(1.0, 3, 1.0)]
        [TestCase(2.0, 5, 2.0)]
        [TestCase(1.0, 6, 0.9)]
        [TestCase(2.2, 10, 1.1)]
        public void PriceTest(double price, int salecode, double expectedPrice)
        {

            double calculatedPrice = PriceCalculator.CalculateSalePrice(price, salecode);
            Assert.AreEqual(calculatedPrice, expectedPrice);

        }


    }
}

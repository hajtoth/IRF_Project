﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet.Common;
using NUnit.Framework;
using project;

namespace CatalogTest
{
    [TestFixture]
    public class ValidateTest
    {
        [TestCase("1,2", true)]
        [TestCase("1.2", true)]
        [TestCase("one point two", false)]
        [TestCase("1.2.2.3", false)]
        [TestCase("1,2,2,3", false)]
        public void PriceValidateTest(string price, bool expectedResult)
        {
            bool result = BookPropertyValidator.ValidatePrice(price);
            Assert.AreEqual(result, expectedResult);
        }

        [TestCase("11/12/2020", true)]
        [TestCase("2020. 12. 11.", false)]
        [TestCase("2020.12.11.", false)]
        [TestCase("20.12.11.", false)]
        [TestCase("2020-11-12", false)]
        [TestCase("2020-12-11", false)]
        [TestCase("11/dec/2020", false)]

        public void DateValidateTest(string publish_date, bool expectedResult)
        {
            bool result = BookPropertyValidator.ValidateDate(publish_date);
            Assert.AreEqual(result, expectedResult);
        }

    }


}

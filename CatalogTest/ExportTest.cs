using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using project;

namespace CatalogTest
{
    [TestFixture]
    class ExportTest
    {
        [Test]
        public void ExportCreateFileTest()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    BookId = "asd 12",
                    Author = "test",
                    Title = "ekl",
                    Genre = "rft",
                    Price = 3.1,
                    PublishDate = DateTime.Now,
                    Description = "lpk"
                }
            };
            string filename = "test.csv";

            Export.ExportToCsv(filename, books);

            Assert.IsTrue(File.Exists(filename));
            File.Delete(filename);
        }
    }
}

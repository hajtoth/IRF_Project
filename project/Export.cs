using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public static class Export
    {
        public static void ExportToCsv(string path, List<Book> books)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (var s in books)
                {
                    sw.Write(s.Author);
                    sw.Write(";");
                    sw.Write(s.Title);
                    sw.Write(";");
                    sw.Write(s.Genre);
                    sw.Write(";");
                    sw.Write(s.Price.ToString());
                    sw.Write(";");
                    sw.Write(s.PublishDate.ToString());
                    sw.Write(s.Description);
                    sw.Write(";");
                    sw.WriteLine();
                }
            }
        }
    }
}

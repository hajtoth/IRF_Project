using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace project
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            dataGridView1.Visible = false;

            bindingSource1.DataSource = LoadCatalogXml();
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Refresh();

        }

        private static List<Book> LoadCatalogXml()
        {
            List<Book> readedBooks = new List<Book>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>), new XmlRootAttribute("catalog"));

            using (FileStream fs = new FileStream("catalog.xml", FileMode.Open, FileAccess.Read))
            {
                readedBooks = xmlSerializer.Deserialize(fs) as List<Book>;
            }
            return readedBooks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            dataGridView1.Visible = true;

            panel1.Controls.Add(dataGridView1);
            dataGridView1.Refresh();





        }

        private void button2_Click(object sender, EventArgs e)
        {


            NewBookForm nbf = new NewBookForm();
            DialogResult result = nbf.ShowDialog();

            if (result == DialogResult.OK)
            {
                Book book = new Book();

                book.author = nbf.textBox1.Text;
                book.title = nbf.textBox2.Text;
                book.genre = nbf.textBox3.Text;
                book.price = double.Parse(nbf.textBox4.Text);
                book.publish_date = DateTime.Parse(nbf.textBox6.Text);
                book.description = nbf.textBox5.Text;

                bindingSource1.Add(book);

            }

        }

        private void saleButton_Click(object sender, EventArgs e)
        {

            List<Book> books = bindingSource1.DataSource as List<Book>;
            Random rng = new Random();
            foreach (Book book in books)
            {
                int saleCode = rng.Next(0, 10);
                if (saleCode == 6)
                {
                    book.price *= 0.9;
                }
                else if (saleCode == 7)
                {
                    book.price *= 0.8;
                }
                else if (saleCode == 8)
                {
                    book.price *= 0.7;
                }
                else if (saleCode == 9)
                {
                    book.price *= 0.6;
                }
                else if (saleCode == 5)
                {
                    book.price *= 0.5;
                }

            }
            dataGridView1.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath; // Alapértelmezetten az exe fájlunk mappája fog megnyílni a dialógus ablakban
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv"; // A kiválasztható fájlformátumokat adjuk meg ezzel a sorral. Jelen esetben csak a csv-t fogadjuk el
            sfd.DefaultExt = "csv"; // A csv lesz az alapértelmezetten kiválasztott kiterjesztés
            sfd.AddExtension = true; // Ha ez igaz, akkor hozzáírja a megadott fájlnévhez a kiválasztott kiterjesztést, de érzékeli, ha a felhasználó azt is beírta és nem fogja duplán hozzáírni

            if (sfd.ShowDialog() != DialogResult.OK) return;

            List<Book> books = bindingSource1.DataSource as List<Book>;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                // Végigmegyünk a hallgató lista elemein
                foreach (var s in books)
                {
                    // Egy ciklus iterációban egy sor tartalmát írjuk a fájlba
                    // A StreamWriter Write metódusa a WriteLine-al szemben nem nyit új sort
                    // Így darabokból építhetjük fel a csv fájl pontosvesszővel elválasztott sorait
                    sw.Write(s.author);
                    sw.Write(";");
                    sw.Write(s.title);
                    sw.Write(";");
                    sw.Write(s.genre);
                    sw.Write(";");
                    sw.Write(s.price.ToString());
                    sw.Write(";");
                    sw.Write(s.publish_date.ToString());
                    sw.Write(s.description);
                    sw.Write(";");
                    sw.WriteLine();
                }


            }
        }

    }
}

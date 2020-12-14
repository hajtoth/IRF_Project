using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private int LastBookIdNumber { get; set; }

        public Form1()
        {

            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
           

            timer1.Start();

            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-EN"); ;

            label2.Text = DateTime.Now.ToLongDateString();

            dataGridView1.Visible = false;
            


            bindingSource1.DataSource = LoadCatalogXml();
            LastBookIdNumber = GetMaxId(bindingSource1.DataSource as List<Book>);
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Refresh();

        }

        private int GetMaxId(List<Book> books)
        {
            int[] ids = new int[books.Count];
            int i = 0;
            foreach (var book in books)
            {
                ids[i] = int.Parse(book.BookId.Replace("bk", ""));
                i += 1;
            }
            return ids.Max();
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
            catalog.Visible = false;
            dataGridView1.Visible = true;


            dataGridView1.Refresh();

            saleButton.Enabled = true;
            exportButton.Enabled = true;
            newBookButton.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            catalog.Visible = false;

            NewBookForm nbf = new NewBookForm();
            DialogResult result = nbf.ShowDialog();

            if (result == DialogResult.OK)
            {
                Book book = new Book();
                book.BookId = "bk" + (++LastBookIdNumber);
                book.Author = nbf.authorTextBox.Text;
                book.Title = nbf.titleTextBox.Text;
                book.Genre = nbf.genreTextBox.Text;
                book.Price = double.Parse(nbf.priceTextBox.Text);
                book.PublishDate = DateTime.Parse(nbf.publishdateTextBox.Text);
                book.Description = nbf.descriptionTextBox.Text;

                bindingSource1.Add(book);

            }

        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            catalog.Visible = false;

            List<Book> books = bindingSource1.DataSource as List<Book>;
            Random rng = new Random();
            foreach (Book book in books)
            {
                int saleCode = rng.Next(0, 10);
                double newPrice = PriceCalculator.CalculateSalePrice(book.Price, saleCode);
                book.Price = newPrice;

            }

            dataGridView1.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            catalog.Visible = false;

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath; // Alapértelmezetten az exe fájlunk mappája fog megnyílni a dialógus ablakban
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv"; // A kiválasztható fájlformátumokat adjuk meg ezzel a sorral. Jelen esetben csak a csv-t fogadjuk el
            sfd.DefaultExt = "csv"; // A csv lesz az alapértelmezetten kiválasztott kiterjesztés
            sfd.AddExtension = true; // Ha ez igaz, akkor hozzáírja a megadott fájlnévhez a kiválasztott kiterjesztést, de érzékeli, ha a felhasználó azt is beírta és nem fogja duplán hozzáírni

            if (sfd.ShowDialog() != DialogResult.OK) return;

            Export.ExportToCsv(sfd.FileName, bindingSource1.DataSource as List<Book>);



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            catalog.Visible = true;
            saleButton.Enabled = false;
            exportButton.Enabled = false;
            newBookButton.Enabled = false;

        }
    }

}




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class NewBookForm : Form
    {
        private Book newBook { get; set; }
        public NewBookForm()
        {
            InitializeComponent();
            newBook = new Book(); 
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false; 
        }

        private void author_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(authorTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(authorTextBox.Text))
                    authorTextBox.BackColor = Color.LightGreen;
            }

            else
            {
                e.Cancel = true;
                authorTextBox.BackColor = Color.MediumVioletRed;
                MessageBox.Show("Invalid author.\nSample: Surname, Forename\nRalls, Kim");
                label7.Visible = true;

            }
        }
        private void title_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(titleTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(titleTextBox.Text))
                    titleTextBox.BackColor = Color.LightGreen;
            }

            else
            {
                e.Cancel = true;
                titleTextBox.BackColor = Color.MediumVioletRed;
                MessageBox.Show("Invalid title.\nSample: Midnight Rain");
                label8.Visible = true;

            }
        }

        private void genre_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(genreTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(genreTextBox.Text))
                    genreTextBox.BackColor = Color.LightGreen;
            }

            else
            {
                e.Cancel = true;
                genreTextBox.BackColor = Color.MediumVioletRed;
                MessageBox.Show("Invalid genre.\nSample: Fantasy");
                label9.Visible = true;

            }
        }



        private void price_Validating(object sender, CancelEventArgs e)
        {
            if (BookPropertyValidator.ValidatePrice(priceTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(priceTextBox.Text))
                    priceTextBox.BackColor = Color.LightGreen;
            }

            else
            {
                e.Cancel = true;
                priceTextBox.BackColor = Color.MediumVioletRed;
                MessageBox.Show("Invalid price.\nSample: 59,95");
                label10.Visible = true;

            }
        }

        private void publishdate_Validating(object sender, CancelEventArgs e)
        {

            if (BookPropertyValidator.ValidateDate(publishdateTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(publishdateTextBox.Text))
                    publishdateTextBox.BackColor = Color.LightGreen;
            }

            else
            {
                e.Cancel = true;
                publishdateTextBox.BackColor = Color.MediumVioletRed;
                MessageBox.Show("Invalid publish date.\nSample: 2000. 12. 16.");
                label11.Visible = true;

            }
        }
        //private void textBox6_Validating(object sender, CancelEventArgs e)
        //    {
        //        Regex regex = new Regex(@"^(?!\s*$).+");

        //        if (regex.IsMatch(textBox6.Text))
        //        {
        //            e.Cancel = false;

        //            if (!String.IsNullOrWhiteSpace(textBox6.Text))
        //                textBox6.BackColor = Color.LightGreen;
        //        }

        //        else
        //        {
        //            e.Cancel = true;
        //            textBox6.BackColor = Color.MediumVioletRed;
        //            MessageBox.Show("Invalid description.\nSample: ....");
        //            label12.Visible = true;

        //        }
        //    }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
    }


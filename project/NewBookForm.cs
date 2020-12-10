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

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(textBox1.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textBox1.Text))
                    textBox1.BackColor = Color.LightGreen;
            }

            else
            {
                e.Cancel = true;
                textBox1.BackColor = Color.MediumVioletRed;
                MessageBox.Show("Invalid author.\nSample: Surname, Forename\nRalls, Kim");
                label7.Visible = true;

            }
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(textBox2.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textBox2.Text))
                    textBox2.BackColor = Color.LightGreen;
            }

            else
            {
                e.Cancel = true;
                textBox2.BackColor = Color.MediumVioletRed;
                MessageBox.Show("Invalid title.\nSample: Midnight Rain");
                label7.Visible = true;

            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(textBox3.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textBox3.Text))
                    textBox3.BackColor = Color.LightGreen;
            }

            else
            {
                e.Cancel = true;
                textBox3.BackColor = Color.MediumVioletRed;
                MessageBox.Show("Invalid genre.\nSample: Fantasy");
                label7.Visible = true;

            }
        }



        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (BookPropertyValidator.ValidatePrice(textBox4.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textBox4.Text))
                    textBox4.BackColor = Color.LightGreen;
            }

            else
            {
                e.Cancel = true;
                textBox4.BackColor = Color.MediumVioletRed;
                MessageBox.Show("Invalid price.\nSample: 59,95");
                label7.Visible = true;

            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[-+]?[0-9]*\\.?[0-9]+([eE][-+]?[0-9]+)?$");

            if (regex.IsMatch(textBox5.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textBox5.Text))
                    textBox5.BackColor = Color.LightGreen;
            }

            else
            {
                e.Cancel = true;
                textBox5.BackColor = Color.MediumVioletRed;
                MessageBox.Show("Invalid publish date.\nSample: 2000. 12. 16.");
                label7.Visible = true;

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
        //            label7.Visible = true;

        //        }
        //    }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
    }


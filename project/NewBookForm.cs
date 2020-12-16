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
        public NewBookForm()
        {
            InitializeComponent();
            invalidAuthorLabel.Visible = false;
            authorSampleLabel.Visible = false;
            invalidTitleLabel.Visible = false;
            invaledGenreLabel.Visible = false;
            invalidPriceLabel.Visible = false;
            publishDateSampleLabel.Visible = false;
            invalidPublishDateLabel.Visible = false;

        }

        private void author_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(authorTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(authorTextBox.Text))
                    authorTextBox.BackColor = Color.FromArgb(154, 208, 208);
            }

            else
            {
                e.Cancel = true;
                authorTextBox.BackColor = Color.FromArgb(214, 140, 140);
                MessageBox.Show("Invalid author.\nSample: Surname, Forename\nRalls, Kim");
                invalidAuthorLabel.Visible = true;
                authorSampleLabel.Visible = true;

            }
        }
        private void title_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(titleTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(titleTextBox.Text))
                    titleTextBox.BackColor = Color.FromArgb(154, 208, 208);
            }

            else
            {
                e.Cancel = true;
                titleTextBox.BackColor = Color.FromArgb(214, 140, 140);
                MessageBox.Show("Invalid title.\nSample: Midnight Rain");
                invalidTitleLabel.Visible = true;

            }
        }

        private void genre_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(genreTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(genreTextBox.Text))
                    genreTextBox.BackColor = Color.FromArgb(154, 208, 208);
            }

            else
            {
                e.Cancel = true;
                genreTextBox.BackColor = Color.FromArgb(214, 140, 140);
                MessageBox.Show("Invalid genre.\nSample: Fantasy");
                invaledGenreLabel.Visible = true;

            }
        }



        private void price_Validating(object sender, CancelEventArgs e)
        {
            if (BookPropertyValidator.ValidatePrice(priceTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(priceTextBox.Text))
                    priceTextBox.BackColor = Color.FromArgb(154, 208, 208);
            }

            else
            {
                e.Cancel = true;
                priceTextBox.BackColor = Color.FromArgb(214, 140, 140);
                MessageBox.Show("Invalid price.\nSample: 59,95");
                invalidPriceLabel.Visible = true;

            }
        }

        private void publishdate_Validating(object sender, CancelEventArgs e)
        {

            if (BookPropertyValidator.ValidateDate(publishdateTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(publishdateTextBox.Text))
                    publishdateTextBox.BackColor = Color.FromArgb(154, 208, 208);
            }

            else
            {
                e.Cancel = true;
                publishdateTextBox.BackColor = Color.FromArgb(214, 140, 140);
                MessageBox.Show("Invalid publish date.\nSample: mm/dd/yy e.g. 12/30/2000");
                invalidPublishDateLabel.Visible = true;

            }
        }

    }
}


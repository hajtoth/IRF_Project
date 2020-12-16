namespace project
{
    partial class NewBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.publishdateTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.publishDateLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.invalidAuthorLabel = new System.Windows.Forms.Label();
            this.invalidTitleLabel = new System.Windows.Forms.Label();
            this.invaledGenreLabel = new System.Windows.Forms.Label();
            this.invalidPriceLabel = new System.Windows.Forms.Label();
            this.invalidPublishDateLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.authorSampleLabel = new System.Windows.Forms.Label();
            this.requiredLabel = new System.Windows.Forms.Label();
            this.publishDateSampleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(292, 42);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(193, 24);
            this.authorTextBox.TabIndex = 0;
            this.authorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.author_Validating);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(292, 85);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(193, 24);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.title_Validating);
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(292, 127);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(193, 24);
            this.genreTextBox.TabIndex = 2;
            this.genreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.genre_Validating);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(292, 169);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(193, 24);
            this.priceTextBox.TabIndex = 3;
            this.priceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.price_Validating);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(292, 254);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(193, 24);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // publishdateTextBox
            // 
            this.publishdateTextBox.Location = new System.Drawing.Point(292, 212);
            this.publishdateTextBox.Name = "publishdateTextBox";
            this.publishdateTextBox.Size = new System.Drawing.Size(193, 24);
            this.publishdateTextBox.TabIndex = 4;
            this.publishdateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.publishdate_Validating);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(131, 42);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(94, 23);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Author*";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(131, 85);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(82, 23);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Title*";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(131, 127);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(82, 23);
            this.genreLabel.TabIndex = 8;
            this.genreLabel.Text = "Genre*";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(131, 169);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(82, 23);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Price*";
            // 
            // publishDateLabel
            // 
            this.publishDateLabel.AutoSize = true;
            this.publishDateLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishDateLabel.Location = new System.Drawing.Point(131, 212);
            this.publishDateLabel.Name = "publishDateLabel";
            this.publishDateLabel.Size = new System.Drawing.Size(166, 23);
            this.publishDateLabel.TabIndex = 10;
            this.publishDateLabel.Text = "Publish date*";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(131, 254);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(142, 23);
            this.descriptionLabel.TabIndex = 11;
            this.descriptionLabel.Text = "Description";
            // 
            // invalidAuthorLabel
            // 
            this.invalidAuthorLabel.AutoSize = true;
            this.invalidAuthorLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invalidAuthorLabel.Location = new System.Drawing.Point(93, 55);
            this.invalidAuthorLabel.Name = "invalidAuthorLabel";
            this.invalidAuthorLabel.Size = new System.Drawing.Size(169, 19);
            this.invalidAuthorLabel.TabIndex = 12;
            this.invalidAuthorLabel.Text = "Invalid author. ";
            // 
            // invalidTitleLabel
            // 
            this.invalidTitleLabel.AutoSize = true;
            this.invalidTitleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invalidTitleLabel.Location = new System.Drawing.Point(93, 102);
            this.invalidTitleLabel.Name = "invalidTitleLabel";
            this.invalidTitleLabel.Size = new System.Drawing.Size(369, 19);
            this.invalidTitleLabel.TabIndex = 13;
            this.invalidTitleLabel.Text = "Invalid title. Sample: Midnight Rain";
            // 
            // invaledGenreLabel
            // 
            this.invaledGenreLabel.AutoSize = true;
            this.invaledGenreLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invaledGenreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invaledGenreLabel.Location = new System.Drawing.Point(93, 144);
            this.invaledGenreLabel.Name = "invaledGenreLabel";
            this.invaledGenreLabel.Size = new System.Drawing.Size(308, 17);
            this.invaledGenreLabel.TabIndex = 14;
            this.invaledGenreLabel.Text = "Invalid genre. Sample: Fantasy";
            // 
            // invalidPriceLabel
            // 
            this.invalidPriceLabel.AutoSize = true;
            this.invalidPriceLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invalidPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invalidPriceLabel.Location = new System.Drawing.Point(93, 185);
            this.invalidPriceLabel.Name = "invalidPriceLabel";
            this.invalidPriceLabel.Size = new System.Drawing.Size(288, 17);
            this.invalidPriceLabel.TabIndex = 15;
            this.invalidPriceLabel.Text = "Invalid price. Sample: 59,95";
            // 
            // invalidPublishDateLabel
            // 
            this.invalidPublishDateLabel.AutoSize = true;
            this.invalidPublishDateLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invalidPublishDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invalidPublishDateLabel.Location = new System.Drawing.Point(93, 228);
            this.invalidPublishDateLabel.Name = "invalidPublishDateLabel";
            this.invalidPublishDateLabel.Size = new System.Drawing.Size(218, 17);
            this.invalidPublishDateLabel.TabIndex = 16;
            this.invalidPublishDateLabel.Text = "Invalid publish date.";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.okButton.Location = new System.Drawing.Point(391, 332);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(110, 37);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.Location = new System.Drawing.Point(242, 332);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 37);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // authorSampleLabel
            // 
            this.authorSampleLabel.AutoSize = true;
            this.authorSampleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorSampleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorSampleLabel.Location = new System.Drawing.Point(93, 68);
            this.authorSampleLabel.Name = "authorSampleLabel";
            this.authorSampleLabel.Size = new System.Drawing.Size(429, 19);
            this.authorSampleLabel.TabIndex = 18;
            this.authorSampleLabel.Text = "Sample: Surname, Forename e. g. Ralls, Kim";
            // 
            // requiredLabel
            // 
            this.requiredLabel.AutoSize = true;
            this.requiredLabel.Location = new System.Drawing.Point(292, 23);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.Size = new System.Drawing.Size(188, 17);
            this.requiredLabel.TabIndex = 19;
            this.requiredLabel.Text = "* Required field. ";
            // 
            // publishDateSampleLabel
            // 
            this.publishDateSampleLabel.AutoSize = true;
            this.publishDateSampleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.publishDateSampleLabel.Location = new System.Drawing.Point(95, 241);
            this.publishDateSampleLabel.Name = "publishDateSampleLabel";
            this.publishDateSampleLabel.Size = new System.Drawing.Size(338, 17);
            this.publishDateSampleLabel.TabIndex = 20;
            this.publishDateSampleLabel.Text = "Sample: mm/dd/yy, e.g. 12/30/2000";
            // 
            // NewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(577, 381);
            this.Controls.Add(this.publishDateSampleLabel);
            this.Controls.Add(this.requiredLabel);
            this.Controls.Add(this.authorSampleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.invalidPublishDateLabel);
            this.Controls.Add(this.invalidPriceLabel);
            this.Controls.Add(this.invaledGenreLabel);
            this.Controls.Add(this.invalidTitleLabel);
            this.Controls.Add(this.invalidAuthorLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.publishDateLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.publishdateTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "NewBookForm";
            this.Text = "Add new book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox authorTextBox;
        public System.Windows.Forms.TextBox titleTextBox;
        public System.Windows.Forms.TextBox genreTextBox;
        public System.Windows.Forms.TextBox priceTextBox;
        public System.Windows.Forms.TextBox descriptionTextBox;
        public System.Windows.Forms.TextBox publishdateTextBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label publishDateLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label invalidAuthorLabel;
        private System.Windows.Forms.Label invalidTitleLabel;
        private System.Windows.Forms.Label invaledGenreLabel;
        private System.Windows.Forms.Label invalidPriceLabel;
        private System.Windows.Forms.Label invalidPublishDateLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label authorSampleLabel;
        private System.Windows.Forms.Label requiredLabel;
        private System.Windows.Forms.Label publishDateSampleLabel;
    }
}
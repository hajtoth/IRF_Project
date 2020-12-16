namespace project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.displayBookButton = new System.Windows.Forms.Button();
            this.newBookButton = new System.Windows.Forms.Button();
            this.saleButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            this.catalog = new System.Windows.Forms.Label();
            this.mainPageButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // displayBookButton
            // 
            this.displayBookButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayBookButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.displayBookButton.Location = new System.Drawing.Point(27, 224);
            this.displayBookButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayBookButton.Name = "displayBookButton";
            this.displayBookButton.Size = new System.Drawing.Size(153, 77);
            this.displayBookButton.TabIndex = 4;
            this.displayBookButton.Text = "Display books";
            this.displayBookButton.UseVisualStyleBackColor = false;
            this.displayBookButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // newBookButton
            // 
            this.newBookButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newBookButton.Enabled = false;
            this.newBookButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newBookButton.Location = new System.Drawing.Point(27, 311);
            this.newBookButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newBookButton.Name = "newBookButton";
            this.newBookButton.Size = new System.Drawing.Size(153, 77);
            this.newBookButton.TabIndex = 5;
            this.newBookButton.Text = "New book";
            this.newBookButton.UseVisualStyleBackColor = false;
            this.newBookButton.Click += new System.EventHandler(this.NewBookButton_Click);
            // 
            // saleButton
            // 
            this.saleButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saleButton.Enabled = false;
            this.saleButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saleButton.Location = new System.Drawing.Point(27, 398);
            this.saleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(153, 77);
            this.saleButton.TabIndex = 6;
            this.saleButton.Text = "Sale";
            this.saleButton.UseVisualStyleBackColor = false;
            this.saleButton.Click += new System.EventHandler(this.SaleButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportButton.Enabled = false;
            this.exportButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exportButton.Location = new System.Drawing.Point(27, 485);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(153, 77);
            this.exportButton.TabIndex = 7;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 497);
            this.dataGridView1.TabIndex = 8;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeLabel.Location = new System.Drawing.Point(1112, 21);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(82, 23);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "label1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateLabel.Location = new System.Drawing.Point(785, 21);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(82, 23);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "label2";
            // 
            // catalog
            // 
            this.catalog.AutoSize = true;
            this.catalog.BackColor = System.Drawing.Color.Transparent;
            this.catalog.Font = new System.Drawing.Font("Lucida Sans Typewriter", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catalog.Location = new System.Drawing.Point(714, 376);
            this.catalog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(679, 164);
            this.catalog.TabIndex = 11;
            this.catalog.Text = "Catalog";
            // 
            // mainPageButton
            // 
            this.mainPageButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPageButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPageButton.Location = new System.Drawing.Point(27, 65);
            this.mainPageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPageButton.Name = "mainPageButton";
            this.mainPageButton.Size = new System.Drawing.Size(153, 77);
            this.mainPageButton.TabIndex = 3;
            this.mainPageButton.Text = "Main page";
            this.mainPageButton.UseVisualStyleBackColor = false;
            this.mainPageButton.Click += new System.EventHandler(this.mainPageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1565, 771);
            this.Controls.Add(this.mainPageButton);
            this.Controls.Add(this.catalog);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.saleButton);
            this.Controls.Add(this.newBookButton);
            this.Controls.Add(this.displayBookButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button displayBookButton;
        private System.Windows.Forms.Button newBookButton;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label catalog;
        private System.Windows.Forms.Button mainPageButton;
    }
}


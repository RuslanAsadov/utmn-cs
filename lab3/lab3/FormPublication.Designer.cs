namespace lab3
{
    partial class FormPublication
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
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.doi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.udc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pages = new System.Windows.Forms.NumericUpDown();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.citation = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.authors = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citation)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(145, 320);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(144, 30);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Создать публикацию";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(51, 45);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(145, 20);
            this.title.TabIndex = 2;
            this.title.Text = "Новая публикация";
            // 
            // doi
            // 
            this.doi.Location = new System.Drawing.Point(225, 45);
            this.doi.Name = "doi";
            this.doi.Size = new System.Drawing.Size(145, 20);
            this.doi.TabIndex = 4;
            this.doi.Text = "00.0000/0000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Код DOI";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(225, 97);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(145, 20);
            this.type.TabIndex = 8;
            this.type.Text = "Статья";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Тип";
            // 
            // udc
            // 
            this.udc.Location = new System.Drawing.Point(51, 97);
            this.udc.Name = "udc";
            this.udc.Size = new System.Drawing.Size(145, 20);
            this.udc.TabIndex = 6;
            this.udc.Text = "000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "УДК";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата создания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Количество страниц";
            // 
            // pages
            // 
            this.pages.Location = new System.Drawing.Point(51, 147);
            this.pages.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(145, 20);
            this.pages.TabIndex = 13;
            this.pages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(225, 146);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(145, 20);
            this.date.TabIndex = 14;
            // 
            // citation
            // 
            this.citation.Location = new System.Drawing.Point(51, 197);
            this.citation.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.citation.Name = "citation";
            this.citation.Size = new System.Drawing.Size(145, 20);
            this.citation.TabIndex = 16;
            this.citation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Цитируемость";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Издательство";
            // 
            // publisher
            // 
            this.publisher.DisplayMember = "Name";
            this.publisher.FormattingEnabled = true;
            this.publisher.Location = new System.Drawing.Point(225, 197);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(145, 21);
            this.publisher.TabIndex = 18;
            this.publisher.ValueMember = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Авторы";
            // 
            // authors
            // 
            this.authors.DisplayMember = "FullName";
            this.authors.FormattingEnabled = true;
            this.authors.Location = new System.Drawing.Point(51, 247);
            this.authors.Name = "authors";
            this.authors.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.authors.Size = new System.Drawing.Size(319, 56);
            this.authors.TabIndex = 20;
            this.authors.ValueMember = "Id";
            // 
            // FormPublication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 377);
            this.Controls.Add(this.authors);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.citation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.udc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPublication";
            this.Text = "Новая публикация";
            this.Load += new System.EventHandler(this.FormPublication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox doi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox udc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown pages;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.NumericUpDown citation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox publisher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox authors;
    }
}
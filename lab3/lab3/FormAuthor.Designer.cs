namespace lab3
{
    partial class FormAuthor
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
            this.work = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scienceDegree = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.citation = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citation)).BeginInit();
            this.SuspendLayout();
            // 
            // work
            // 
            this.work.Location = new System.Drawing.Point(234, 45);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(183, 20);
            this.work.TabIndex = 11;
            this.work.Text = "ТюмГУ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Место работы";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(33, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(183, 20);
            this.name.TabIndex = 9;
            this.name.Text = "Иванов Иван Иванович";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО (латинские или кириллица)";
            // 
            // scienceDegree
            // 
            this.scienceDegree.Location = new System.Drawing.Point(33, 94);
            this.scienceDegree.Name = "scienceDegree";
            this.scienceDegree.Size = new System.Drawing.Size(99, 20);
            this.scienceDegree.TabIndex = 13;
            this.scienceDegree.Text = "Доктор наук";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Научная степень";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(153, 94);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(130, 20);
            this.date.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Дата рождения";
            // 
            // citation
            // 
            this.citation.Location = new System.Drawing.Point(301, 95);
            this.citation.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.citation.Name = "citation";
            this.citation.Size = new System.Drawing.Size(116, 20);
            this.citation.TabIndex = 19;
            this.citation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Индекс цитируемости";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(146, 135);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(145, 29);
            this.create.TabIndex = 20;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // FormAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 191);
            this.Controls.Add(this.create);
            this.Controls.Add(this.citation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scienceDegree);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.work);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAuthor";
            this.Text = "Новый автор";
            ((System.ComponentModel.ISupportInitialize)(this.citation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scienceDegree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown citation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button create;
    }
}
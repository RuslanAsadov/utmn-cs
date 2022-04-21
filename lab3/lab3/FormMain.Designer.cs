namespace lab3
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPublisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.statePages = new System.Windows.Forms.Label();
            this.publicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.udcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPublicationToolStripMenuItem,
            this.addAuthorToolStripMenuItem,
            this.addPublisherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addPublicationToolStripMenuItem
            // 
            this.addPublicationToolStripMenuItem.Name = "addPublicationToolStripMenuItem";
            this.addPublicationToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.addPublicationToolStripMenuItem.Text = "Добавить публикацию";
            this.addPublicationToolStripMenuItem.Click += new System.EventHandler(this.addPublicationToolStripMenuItem_Click);
            // 
            // addAuthorToolStripMenuItem
            // 
            this.addAuthorToolStripMenuItem.Name = "addAuthorToolStripMenuItem";
            this.addAuthorToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.addAuthorToolStripMenuItem.Text = "Добавить автора";
            this.addAuthorToolStripMenuItem.Click += new System.EventHandler(this.addAuthorToolStripMenuItem_Click);
            // 
            // addPublisherToolStripMenuItem
            // 
            this.addPublisherToolStripMenuItem.Name = "addPublisherToolStripMenuItem";
            this.addPublisherToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.addPublisherToolStripMenuItem.Text = "Добавить издательство";
            this.addPublisherToolStripMenuItem.Click += new System.EventHandler(this.addPublisherToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.doiDataGridViewTextBoxColumn,
            this.udcDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.countPagesDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.citationDataGridViewTextBoxColumn,
            this.authorsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.publicationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(677, 178);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(12, 233);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 2;
            this.remove.Text = "Удалить";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Удалить выделенную публикацию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Обновить выделенную публикацию";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(248, 234);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 5;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(623, 217);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(42, 39);
            this.next.TabIndex = 6;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(525, 217);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(42, 39);
            this.prev.TabIndex = 7;
            this.prev.Text = "<";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // statePages
            // 
            this.statePages.AutoSize = true;
            this.statePages.Location = new System.Drawing.Point(584, 230);
            this.statePages.Name = "statePages";
            this.statePages.Size = new System.Drawing.Size(24, 13);
            this.statePages.TabIndex = 8;
            this.statePages.Text = "0/0";
            // 
            // publicationBindingSource
            // 
            this.publicationBindingSource.DataSource = typeof(lab3.Publication);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doiDataGridViewTextBoxColumn
            // 
            this.doiDataGridViewTextBoxColumn.DataPropertyName = "Doi";
            this.doiDataGridViewTextBoxColumn.HeaderText = "Код DOI";
            this.doiDataGridViewTextBoxColumn.Name = "doiDataGridViewTextBoxColumn";
            this.doiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // udcDataGridViewTextBoxColumn
            // 
            this.udcDataGridViewTextBoxColumn.DataPropertyName = "Udc";
            this.udcDataGridViewTextBoxColumn.HeaderText = "УДК";
            this.udcDataGridViewTextBoxColumn.Name = "udcDataGridViewTextBoxColumn";
            this.udcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countPagesDataGridViewTextBoxColumn
            // 
            this.countPagesDataGridViewTextBoxColumn.DataPropertyName = "CountPages";
            this.countPagesDataGridViewTextBoxColumn.HeaderText = "Количество страниц";
            this.countPagesDataGridViewTextBoxColumn.Name = "countPagesDataGridViewTextBoxColumn";
            this.countPagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Издательство";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citationDataGridViewTextBoxColumn
            // 
            this.citationDataGridViewTextBoxColumn.DataPropertyName = "Citation";
            this.citationDataGridViewTextBoxColumn.HeaderText = "Цитируемость";
            this.citationDataGridViewTextBoxColumn.Name = "citationDataGridViewTextBoxColumn";
            this.citationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            this.authorsDataGridViewTextBoxColumn.DataPropertyName = "Authors";
            this.authorsDataGridViewTextBoxColumn.HeaderText = "Авторы";
            this.authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            this.authorsDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorsDataGridViewTextBoxColumn.Width = 500;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 271);
            this.Controls.Add(this.statePages);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPublicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPublisherToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Label statePages;
        private System.Windows.Forms.BindingSource publicationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn udcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
    }
}


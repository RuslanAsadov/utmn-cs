﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class FormAuthor : Form
    {
        public FormAuthor()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[a-zA-ZА-Яа-я .]+$");
            if (rgx.IsMatch(name.Text))
            {
                var mainForm = Application.OpenForms.OfType<FormMain>().Single();
                mainForm.authors.Add(new Author()
                {
                    Id = Guid.NewGuid().ToString("N"),
                    FullName = name.Text,
                    BirthDate = date.Value.Date,
                    PlaceOfWork = work.Text,
                    CitationIndex = Convert.ToInt32(citation.Value),
                    ScienceDegree = scienceDegree.Text
                });

                MessageBox.Show("Автор успешно добавлен", "Успех!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Имя не соотвествует критериям", "Ошибка!");
            }
        }
    }
}

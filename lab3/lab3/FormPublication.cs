using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class FormPublication : Form
    {
        List<Author> Authors;
        List<Publisher> Publishers;
        string _Id;
        Publication _data;
        public FormPublication(List<Author> authors, List<Publisher> publishers, Publication data = null)
        {
            _data = data;
            Authors = authors;
            Publishers = publishers;
            InitializeComponent();
        }

        private void FormPublication_Load(object sender, EventArgs e)
        {
            publisher.DataSource = Publishers;
            authors.DataSource = Authors;
            

            _Id = Guid.NewGuid().ToString("N");
            if (_data != null)
            {
                submitButton.Text = "Обновить публикацию";
                this.Text = "Обновление публикации";
                _Id = _data.Id;
                title.Text = _data.Title;
                type.Text = _data.Type;
                doi.Text = _data.Doi;
                udc.Text = _data.Udc;
                pages.Value = _data.CountPages;
                date.Value = _data.CreationDate;
                citation.Value = _data.Citation;
                authors.SelectedItems.Clear();

                for (int i = 0; i < publisher.Items.Count; i++)
                {
                    if ((publisher.Items[i] as Publisher).Id == _data.Publisher.Id)
                    {
                        publisher.SelectedItem = publisher.Items[i];
                    }
                }

                for (int i = 0; i < authors.Items.Count; i++)
                {
                    foreach (Author author in _data.Authors)
                    {
                        if ((authors.Items[i] as Author).Id == author.Id)
                        {
                            authors.SelectedItems.Add(authors.Items[i]);
                        }
                    }
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            List<Author> authorsList= new List<Author>();
            foreach (Author author in authors.SelectedItems)
            {
                authorsList.Add(author);
            }
            var mainForm = Application.OpenForms.OfType<FormMain>().Single();
            mainForm.AddNewPublication(new Publication()
            {
                Id = _Id,
                Title = title.Text,
                Doi = doi.Text,
                Type = type.Text,
                Udc = udc.Text,
                CountPages = Convert.ToInt32(pages.Value),
                CreationDate = date.Value.Date,
                Publisher = Publishers.Single(p => p.Id == (publisher.SelectedItem as Publisher).Id),
                Citation = Convert.ToInt32(citation.Value),
                Authors = authorsList
            });

            if (_data != null)
            {
                MessageBox.Show("Публикация успешно обновлена", "Успех!");
            }
            else
            {
                MessageBox.Show("Публикация успешно создана", "Успех!");
            }

            this.Close();
        }
    }
}

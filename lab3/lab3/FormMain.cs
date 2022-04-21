using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;

namespace lab3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        int pageNumber = 1;
        int pageSize = 2;
        IPagedList<Publication> publicationsCrop;
        List<Publication> publications = new List<Publication>();
        public List<Author> authors = new List<Author>();
        public List<Publisher> publishers = new List<Publisher>();
        public void AddNewPublication(Publication newPublication)
        {
            var existingIndex = publications.FindIndex(r => r.Id == newPublication.Id);
            if (existingIndex != -1)
            {
                publications[existingIndex] = newPublication;
            }
            else
            {
                publications.Add(newPublication);
            }

            RenderTable();
        }

        void RenderTable()
        {
            publicationsCrop = publications.ToPagedList(pageNumber, pageSize);

            publicationBindingSource.Clear();
            foreach (Publication publication in publicationsCrop.ToList())
            {
                publicationBindingSource.Add(publication);
            }
            prev.Enabled = publicationsCrop.HasPreviousPage;
            next.Enabled = publicationsCrop.HasNextPage;
            statePages.Text = string.Format("{0}/{1}", publications.Count > 0 ? pageNumber : 0, publicationsCrop.PageCount);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            authors.Add(new Author()
            {
                Id = "0",
                FullName = "Иванов Иван Иванович",
                BirthDate = new DateTime(1983, 05, 20),
                PlaceOfWork = "ТюмГУ",
                CitationIndex = 23,
                ScienceDegree = "Доктор наук"
            });
            authors.Add(new Author()
            {
                Id = "1",
                FullName = "Сидоров Аркадий Петрович",
                BirthDate = new DateTime(1997, 06, 22),
                PlaceOfWork = "ТИУ",
                CitationIndex = 243,
                ScienceDegree = "Кандидат наук"
            });
            authors.Add(new Author()
            {
                Id = "2",
                FullName = "Алексеев Иван Викторович",
                BirthDate = new DateTime(1978, 08, 12),
                PlaceOfWork = "ТюмГУ",
                CitationIndex = 123,
                ScienceDegree = "Доктор наук"
            });

            publishers.Add(new Publisher()
            {
                Id = "0",
                Name = "Инновации в науке",
                Type = "Журнал",
                CreationDate = new DateTime(2005, 04, 13)
            });
            publishers.Add(new Publisher()
            {
                Id = "1",
                Name = "Будущее планеты",
                Type = "Сборник",
                CreationDate = new DateTime(2009, 06, 23)
            });

            AddNewPublication(new Publication()
            {
                Id = "0",
                Title = "Котлеты без мяса",
                Type = "Статья",
                Doi = "10.1007/b136753",
                Udc = "336.64",
                CountPages = 234,
                CreationDate = new DateTime(2005, 11, 12),
                Publisher = publishers[1],
                Citation = 43,
                Authors = new List<Author> { authors[0] }
            });
            AddNewPublication(new Publication()
            {
                Id = "1",
                Title = "Жизнь на Марсе",
                Type = "Статья",
                Doi = "10.1007/978-3-540-46129-6",
                Udc = "621.355",
                CountPages = 345,
                CreationDate = new DateTime(2000, 08, 08),
                Publisher = publishers[0],
                Citation = 43,
                Authors = new List<Author> { authors[0], authors[1] }
            });
            AddNewPublication(new Publication()
            {
                Id = "2",
                Title = "Будущее вселенной",
                Type = "Доклад",
                Doi = "10.1007/v1312353",
                Udc = "234.342",
                CountPages = 132,
                CreationDate = new DateTime(2001, 06, 04),
                Publisher = publishers[1],
                Citation = 23,
                Authors = new List<Author> { authors[1] }
            });

            RenderTable();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is Publisher)
            {
                e.Value = (e.Value as Publisher).Name;
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "authorsDataGridViewTextBoxColumn")
            {
                List<Author> authorsCollection = (e.Value as List<Author>);
                if (authorsCollection != null && authorsCollection.Count > 0)
                {
                    e.Value = "";
                    Author LastAuthor = authorsCollection.Last();
                    foreach (Author author in authorsCollection)
                    {
                        e.Value += author.FullName + (author.Equals(LastAuthor) ? "" : ", ");
                    }
                }
            }
        }
        private void remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить данную работу?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                var itemToRemove = publications.SingleOrDefault(r => r.Id == id);
                if (itemToRemove != null)
                {
                    publications.Remove(itemToRemove);
                }

                pageNumber = 1;

                RenderTable();
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (publicationsCrop.HasPreviousPage)
            {
                --pageNumber;
                RenderTable();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (publicationsCrop.HasNextPage)
            {
                ++pageNumber;
                RenderTable();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            var publication = publications.SingleOrDefault(r => r.Id == id);
            FormPublication FormPublicationModal = new FormPublication(authors, publishers, publication);
            FormPublicationModal.Show();
        }

        private void addPublicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPublication FormPublicationModal = new FormPublication(authors, publishers);
            FormPublicationModal.Show();
        }

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuthor FormAuthorModal = new FormAuthor();
            FormAuthorModal.Show();
        }

        private void addPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPublisher FormPublisherModal = new FormPublisher();
            FormPublisherModal.Show();
        }
    }
}

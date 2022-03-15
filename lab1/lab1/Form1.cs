using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private List<Cat> Cats { get; set; }
        private Form2 frm2;
        public Form1()
        {
            Cats = GetCats();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            dataGridView1.DataSource = this.Cats;
        }

        private List<Cat> GetCats()
        {
            var list = new List<Cat>();
            list.Add(new Cat { Id = 1, Name = "Мурзик", Color = "Черно-белый" });
            list.Add(new Cat { Id = 2, Name = "Марсик", Color = "Серый" });
            return list;
        }

        // Первая вкладка

        private void button2_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            progress.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();
            frm2.Show();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            this.desctiptionLabel.Text = "Выбран Radio Button: ";
            if (radioButton1.Checked)
            {
                this.desctiptionLabel.Text += "Включить свет";
            }
            else if (radioButton2.Checked)
            {
                this.desctiptionLabel.Text += "Выключить свет";
            }
            this.desctiptionLabel.Text +=
                "\n" +
                "Основные свойства и методы Radio Button:\n" +
                "1. Text - Текст, связанный с элементом \n" +
                "2. Checked - Состояние (выбран или  нет) \n" +
                "3. Cursor - Тип курсора при наведении \n" +
                "4. BackColor - Фоновый цвет \n" +
                "5. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "6. Name - Имя элемента, которое используется в коде \n" +
                "7. Font - Шрифт текста \n" +
                "События: \n" +
                "1. Click - Сработает при клике \n" +
                "2. CheckedChanged - Состояние изменено \n" +
                "3. MouseHover - Сработает при наведении на элемент \n";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.desctiptionLabel.Text =
                "Основные свойства и методы Button:\n" +
                "1. Font - Шрифт текста \n" +
                "2. Text - Текст, связанный с элементом \n" +
                "3. Name - Имя элемента, которое используется в коде \n" +
                "4. Size - Высота и ширина элемента \n" +
                "5. Cursor - Тип курсора при наведении \n" +
                "6. Padding - Внутренние отступы \n" +
                "7. BackColor - Фоновый цвет \n" +
                "8. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. MouseHover - Сработает при наведении на элемент \n" +
                "2. Click - Сработает при клике \n";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.desctiptionLabel.Text =
               "Состояние: " + (CheckBox.Checked ? "Выбран" : "Не выбран") + "\n" +
               "Основные свойства и методы Checkbox:\n" +
               "1. Font - Шрифт текста \n" +
               "2. Text - Текст, связанный с элементом \n" +
               "3. Checked - Состояние (выбран или  нет) \n" +
               "4. Focus() - Метод, устанавливающий фокус на элемент \n" +
               "5. Name - Имя элемента, которое используется в коде \n" +
               "6. Size - Высота и ширина элемента \n" +
               "События: \n" +
               "1. CheckedChanged - Состояние изменено \n" +
               "2. Click - Сработает при клике \n";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.desctiptionLabel.Text =
               "Основные свойства и методы Label:\n" +
               "1. AutoSize - Автоматическое изменение размера элемента под текст \n" +
               "2. BackColor - Фоновый цвет \n" +
               "3. BackgroundImage - Фоновое изображение \n" +
               "4. Cursor - Тип курсора при наведении \n" +
               "5. Font - Шрифт текста \n" +
               "6. Padding - Внутренние отступы \n" +
               "7. Text - Текст, связанный с элементом \n" +
               "8. Name - Имя элемента, которое используется в коде \n" +
               "9. Size - Высота и ширина элемента \n" +
               "События: \n" +
               "1. Click - Сработает при клике \n" +
               "2. MouseHover - Сработает при наведении на элемент \n" +
               "3. TextChanged - Сработает при изменении текста ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.desctiptionLabel.Text =
               "Значение: " + textBox1.Text + "\n" +
               "Основные свойства и методы TextBox:\n" +
               "1. Text - Текст, связанный с элементом \n" +
               "2. BackColor - Фоновый цвет \n" +
               "3. Font - Шрифт текста \n" +
               "4. Focus() - Метод, устанавливающий фокус на элемент \n" +
               "5. Multiline - Можно ли писать несколько строк \n" +
               "6. Name - Имя элемента, которое используется в коде \n" +
               "7. Size - Высота и ширина элемента \n" +
               "8. TextAlign - Выравнивание текста \n" +
               "9. MaxLength - Максимальное количество символов \n" +
               "10. ReadOnly - Только для чтения (Да/Нет) \n" +
               "События: \n" +
               "1. TextChanged - Сработает при изменении текста \n" +
               "2. MouseHover - Сработает при наведении на элемент \n" +
               "3. Click - Сработает при клике ";
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.desctiptionLabel.Text =
               "Значение: " + maskedTextBox1.Text + "\n" +
               "Основные свойства и методы MaskedTextBox:\n" +
               "1. Text - Текст, связанный с элементом \n" +
               "2. BackColor - Фоновый цвет \n" +
               "3. Font - Шрифт текста \n" +
               "4. Mask - Маска, которой будет соответствовать введенный текст   \n" +
               "5. Name - Имя элемента, которое используется в коде \n" +
               "6. Size - Высота и ширина элемента \n" +
               "7. TextAlign - Выравнивание текста \n" +
               "8. Focus() - Метод, устанавливающий фокус на элемент \n" +
               "9. ReadOnly - Только для чтения (Да/Нет) \n" +         
               "События: \n" +
               "1. TextChanged - Сработает при изменении текста \n" +
               "2. MouseHover - Сработает при наведении на элемент \n" +
               "3. MaskInputRejected - Сработает, если введеный символ не соответствует \nпараметрам маски \n" +
               "4. Click - Сработает при клике ";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.desctiptionLabel.Text =
               "Значение: " + numericUpDown1.Value + "\n" +
               "Основные свойства и методы NumericUpDown:\n" +
               "1. BackColor - Фоновый цвет \n" +
               "2. Font - Шрифт текста \n" +
               "3. Focus() - Метод, устанавливающий фокус на элемент \n" +
               "4. Value - Текущее значение элемента \n" +
               "5. Name - Имя элемента, которое используется в коде \n" +
               "6. Size - Высота и ширина элемента \n" +
               "7. TextAlign - Выравнивание текста \n" +
               "8. UpDownAlign - Расположение стрелок вверх/вниз \n" +
               "9. ReadOnly - Только для чтения (Да/Нет) \n" +
               "10. Minimum - Минимальное значение \n" +
               "11. Maximum - Максимальное значение \n" +
               "12. Increment - Шаг при увеличении/уменьшении значения при помощи стрелок \n" +
               "События: \n" +
               "1. ValueChanged - Сработает, когда значение будет изменено \n" +
               "2. MouseHover - Сработает при наведении на элемент \n" +
               "3. Click - Сработает при клике ";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.desctiptionLabel.Text =
               "Выбран: " + comboBox1.SelectedItem + "\n" +
               "Основные свойства и методы ComboBox:\n" +
               "1. BackColor - Фоновый цвет \n" +
               "2. Font - Шрифт текста \n" +
               "3. Focus() - Метод, устанавливающий фокус на элемент \n" +
               "4. Text - Текст, связанный с элементом \n" +
               "5. Name - Имя элемента, которое используется в коде \n" +
               "6. Size - Высота и ширина элемента \n" +
               "7. Items - Элементы в выпадающем списке \n" +
               "8. SelectedIndex - Выбранный индекс \n" +
               "9. SelectedItem - Выбранный элемент \n" +
               "События: \n" +
               "1. SelectedIndexChanged - Сработает, когда индекс будет изменен \n" +
               "2. SelectedValueChanged - Сработает, когда значение будет изменено \n" +
               "3. MouseHover - Сработает при наведении на элемент \n" +
               "4. Click - Сработает при клике";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.desctiptionLabel.Text =
               "Выбрана дата: " + dateTimePicker1.Value + "\n" +
               "Основные свойства и методы DateTimePicker:\n" +
               "1. Font - Шрифт текста \n" +
               "2. Focus() - Метод, устанавливающий фокус на элемент \n" +
               "3. Value - Значение элемента \n" +
               "4. Name - Имя элемента, которое используется в коде \n" +
               "5. Size - Высота и ширина элемента \n" +
               "6. Cursor - Тип курсора при наведении \n" +
               "7. Format - Формат отображения даты \n" +
               "8. MinDate - Минимальная дата \n" +
               "9. MaxDate - Максимальная дата \n" +
               "10. CalendarForeColor - Цвет текста в области месяца \n" +
               "11. CalendarMonthBackground - Фоновый цвет в области месяца \n" +
               "13. CalendarTitleBackColor - Фоновый цвет заголовка календаря \n" +
               "14. CalendarTitleForeColor - Цвет заголовка календаря\n" +
               "15. CalendarTrailingForeColor - Цвет завершающих дней предыдущего месяца \nи начальных дней следующего месяца \n" +
               "События: \n" +
               "1. ValueChanged - Сработает, когда значение будет изменено \n" +
               "2. Enter - Сработает, когда элемент будет в фокусе \n" +
               "3. Click - Сработает при клике ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.desctiptionLabel.Text =
               "Основные свойства и методы PictureBox:\n" +
               "1. Name - Имя элемента, которое используется в коде \n" +
               "2. Cursor - Тип курсора при наведении \n" +
               "3. Image - Само изображение \n" +
               "4. Size - Высота и ширина элемента \n" +
               "События: \n" +
               "1. Click - Сработает при клике ";
        }

        // Вторая вкладка

        private void button5_Click(object sender, EventArgs e)
        {
            this.descriptionLabel2.Text =
               "Основные свойства и методы FolderBrowserDialog:\n" +
               "1. Name - Имя элемента, которое используется в коде \n" +
               "2. Description - Описание для пользователя \n" +
               "3. RootFolder - Корневой каталог, с которого начинается обзор \n" +
               "4. SelectedPath - Путь к выбранной папке \n" +
               "5. ShowNewFolderButton - Показывать ли кнопку создания новой папки \n" +
               "6. ShowDialog() - метод, запускающий диалоговое окно с выбором \n" +
               "События: \n" +
               "1. Disposed - срабатывает при удалении компонента\n" +
               "2. HelpRequest - срабатывает при нажатии 'Help' в диалоговом окне";

            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                listBox1.Items.Clear();
                foreach (var item in Directory.GetFiles(folderName))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.descriptionLabel2.Text =
               "Основные свойства и методы OpenFileDialog:\n" +
               "1. Name - Имя элемента, которое используется в коде \n" +
               "2. Title - Заголовок диалогового окна с выбором \n" +
               "3. InitialDirectory - Первоначальная директория \n" +
               "4. AddExtension - Добавлять ли расширения к именам файлов \nавтоматически \n" +
               "5. CheckFileExists - Проверить, существет ли выбранный файл \n" +
               "6. CheckPathExists - Проверить, существет ли выбранный путь \n" +
               "7. Multiselect - Можно ли выбирать несколько элементов \n" +
               "8. DefaultExt - Расширение файла по умолчанию \n" +
               "9. Filter - Фильтр по файлам \n" +
               "10. ShowDialog() - метод, запускающий диалоговое окно с выбором \n" +
               "11. OpenFile() - метод, открывающий выбранный файл \n" +
               "События: \n" +
               "1. Disposed - срабатывает при удалении компонента\n" +
               "2. FileOk - срабатывает когда пользователь нажимает \n'Открыть' или 'Сохранить' в диалоговом окне\n" +
               "3. HelpRequest - срабатывает при нажатии 'Help' в диалоговом окне";

            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] fileNames = openFileDialog1.FileNames;
                foreach (var item in fileNames)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.descriptionLabel2.Text =
               "Основные свойства и методы SaveFileDialog:\n" +
               "1. Name - Имя элемента, которое используется в коде \n" +
               "2. Title - Заголовок диалогового окна с выбором  \n" +
               "3. InitialDirectory - Первоначальная директория \n" +
               "4. AddExtension - Добавлять ли расширения к именам файлов \nавтоматически \n" +
               "5. CheckFileExists - Проверить, существет ли выбранный файл \n" +
               "6. CheckPathExists - Проверить, существет ли выбранный путь \n" +
               "9. DefaultExt - Расширение файла по умолчанию \n" +
               "10. Filter - Фильтр по файлам \n" +
               "10. FileName - Имя файла \n" +
               "11. ShowDialog() - метод, запускающий диалоговое окно с выбором, куда \nсохранить \n" +
               "12. OpenFile() - метод, открывающий данный файл \n" +
               "События: \n" +
               "1. Disposed - срабатывает при удалении компонента\n" +
               "2. FileOk - срабатывает когда пользователь нажимает \n'Открыть' или 'Сохранить' в диалоговом окне\n" +
               "3. HelpRequest - срабатывает при нажатии 'Help' в диалоговом окне";

            saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
            saveFileDialog1.FileName = "cat";
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBox1.Image.Save(saveFileDialog1.FileName, format);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.descriptionLabel2.Text =
               "Основные свойства и методы ListBox:\n" +
               "1. Name - Имя элемента, которое используется в коде \n" +
               "2. BackColor - Фоновый цвет \n" +
               "3. Font - Шрифт текста \n" +
               "4. ForeColor - Цвет текста \n" +
               "5. Items - Элементы списка \n" +
               "6. Size - Высота и ширина элемента \n" +
               "7. SelectedIndeex - Индекс выбранного элемента \n" +
               "8. SelectedIndices - Индексы выбранных элементов \n" +
               "9. SelectdItem - Выбранный элемент\n" +
               "10. SelectedItems - Выбранные элементы \n" +
               "11. Sorted - сортирован ли список \n" +
               "12. Focus() - Метод, устанавливающий фокус на элемент \n" +
               "События: \n" +
               "1. SelectedIndexChanged - Сработает, когда активный индекс изменится\n" +
               "2. SelectedValueChanged - Сработает, когда значение будет \nизменено \n" +
               "3. Click - Сработает при клике ";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            this.descriptionLabel2.Text =
               "Основные свойства и методы GroupBox:\n" +
               "1. Name - Имя элемента, которое используется в коде \n" +
               "2. BackColor - Фоновый цвет \n" +
               "3. BackgroundImage - Фоновое изображение \n" +
               "4. Font - Шрифт текста \n" +
               "5. Size - Высота и ширина элемента \n" +
               "6. Focus() - Метод, устанавливающий фокус на элемент \n" +
               "7. Text - Текст, связанный с элементом \n" +
               "8. Cursor - Тип курсора при наведении \n" +
               "9. Contains(Control) - Проверить, содержит ли определенные \nдочерние элементы \n" +
               "События: \n" +
               "1. Click - Сработает при клике \n" +
               "2. Enter - Сработает при фокусе на элементы внутри";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.descriptionLabel2.Text =
               "Основные свойства и методы Panel:\n" +
               "1. Name - Имя элемента, которое используется в коде \n" +
               "2. BackColor - Фоновый цвет \n" +
               "3. BackgroundImage - Фоновое изображение \n" +
               "4. Font - Шрифт текста \n" +
               "5. Size - Высота и ширина элемента \n" +
               "6. Focus() - Метод, устанавливающий фокус на элемент \n" +
               "7. Cursor - Тип курсора при наведении \n" +
               "8. Contains(Control) - Проверить, содержит ли определенные \nдочерние элементы \n" +
               "События: \n" +
               "1. Click - Сработает при клике \n" +
               "2. Enter - Сработает при фокусе на элементы внутри ";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.descriptionLabel2.Text =
               "Основные свойства и методы DataGridView:\n" +
               "1. Name - Имя элемента, которое используется в коде \n" +
               "2. BackColor - Фоновый цвет \n" +
               "3. RowTemplate - Шаблон для строк (настройка высоты, \nпараметы разрешения на запись и др) \n" +
               "4. DataSource - Данные для элемента \n" +
               "5. Size - Высота и ширина элемента \n" +
               "6. ReadOnly - Только для чтения (Да/Нет) \n" +
               "7. MultiSelect - Возможность множественного выбора \n" +
               "8. CurrentCell - Текущая ячейка \n" +
               "9. CurrentRow - Текущая строка \n" +
               "10. RowCount - Количество строк \n" +
               "11. Columns - Коллекция колонок \n" +
               "12. Rows - Коллекция строк \n" +
               "13. SelectedCells - Выбранные ячейка \n" +
               "14. SelectedColumns - Выбранные колонки \n" +
               "15. SelectedRows - Выбранные строки \n" +
               "16. SortOrder - Порядок сортировки \n" +
               "17. SortedColumn - Столбец, по которому выполнена сортировка \n" +
               "18. BeginEdit() - метод, переводящий текущую ячейку \nв режим редактирования \n" +
               "19. CancelEdit() - метод, отменяющий режим редактирования \nдля текущей выбранной ячейки \n" +
               "20. ClearSelection() - метод, отменяющий текущие выделения ячеек \n" +
               "21. EndEdit() - метод, завершающий изменение в текущей ячейке \n" +
               "События: \n" +
               "1. CellBeginEdit - Сработает при запуске режима правки для \nвыбранных ячеек \n" +
               "2. CellClick - Сработает при клике по ячейке \n" +
               "3. CellEndEdit - Сработает при при остановке режима правки \nдля выбранной ячейки \n" +
               "4. ColumnSortModeChanged - Сработает при изменении значения \nсвойства SortMode для столбца \n" +
               "5. Sorted - Сработает когда завершится операция сортировки  \n" +
               "6. CellValueChanged - Сработает при изменении значения ячейки \n";
        }

        // Menu Strip

        private void submenu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string menuStripInfo =
                "Основные свойства и методы MenuStrip:\n" +
                "1. Name - Имя элемента, которое используется в коде \n" +
                "2. Items - Элементы в меню \n" +
                "3. BackColor - Фоновый цвет \n" +
                "4. Font - Шрифт текста \n" +
                "5. Padding - Внутренние отступы \n" +
                "6. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. ItemClicked - Сработает при клике на один из элементов меню \n";

            // так как не привязан к конкретной вкладке, добавляем сразу на две
            this.desctiptionLabel.Text = menuStripInfo;
            this.descriptionLabel2.Text = menuStripInfo;
        }

        private void submenu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

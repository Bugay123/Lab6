using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;

namespace Lab6
{
    public partial class Form1 : Form
    {

        private string fn = string.Empty;
        private bool docChanged = false;
        private StringReader m_myReader; //потік для текстового поля
        private int m_PrintPageNumber; //поточна сторінка для друку

        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = string.Empty;
            richTextBox1.Font = fontDialog1.Font;
            this.Text = "NkEdit - Новий документ";
            // вивести панель инструментов
            toolStrip1.Visible = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            openFileDialog1.Title = "Відкрити документ";

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "doc1.txt";
            saveFileDialog1.Filter = "(*.txt) | *.txt | All Files(*.*) | *.*";
            saveFileDialog1.Title = " Зберегти документ";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear(); //створити новий документ
        }
        private void NewDocument()
        {
            richTextBox1.Clear(); //створити новий документ
            fn = string.Empty;
            saveFileDialog1.FileName = "doc1.txt";
        }
        private void OpenDocument()
        {
            openFileDialog1.FileName = string.Empty;
            // Відобразити діалог відкриття файлу
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn = openFileDialog1.FileName;
                // відобразити им'я файла у заголовку вікна
                this.Text = fn;
                try
                {
                    // читання даних з файлу
                    System.IO.StreamReader sr = new System.IO.StreamReader(fn);
                    richTextBox1.Text = sr.ReadToEnd();
                    richTextBox1.SelectionStart = richTextBox1.TextLength;
                    sr.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(" Помилка читання файла.\n " + exc.ToString(), " NkEdit ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int SaveDocument()
        {
            int result = 0;
            if (fn == string.Empty)
            {
                // відобразити діалог Зберегти
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fn = saveFileDialog1.FileName;
                    // відобразити им&#39;я файла у заголовку вікна
                    this.Text = fn;
                }
                else result = -1;
            }
            // зберегти файл
            if (fn != string.Empty)
            {
                try
                {
                    // отримуємо інформацию про файл fn
                    System.IO.FileInfo fi = new System.IO.FileInfo(fn);
                    // створюємо потік для запису (перезаписуємо файл)
                    System.IO.StreamWriter sw = fi.CreateText();
                    // записуємо дані
                    sw.Write(richTextBox1.Text);
                    // закриваємо потік
                    sw.Close();
                    result = 0;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), " NkEdit ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return result;
        }
        private int SaveDocumentAs()
        {
            int result = 0;
            // відобразити діалог Зберегти
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn = saveFileDialog1.FileName;
                // відобразити им&#39;я файла у заголовку вікна
                this.Text = fn;
            }
            try
            {
                // отримуємо інформацию про файл fn
                System.IO.FileInfo fi = new System.IO.FileInfo(fn);
                // створюємо потік для запису (перезаписуємо файл)
                System.IO.StreamWriter sw = fi.CreateText();
                // записуємо дані
                sw.Write(richTextBox1.Text);
                // закриваємо потік
                sw.Close();
                result = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "NkEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        private void PrintDocument()
        {
            //організація друку
            m_PrintPageNumber = 1;
            string strText = this.richTextBox1.Text;
            m_myReader = new StringReader(strText);
            printDialog1.ShowDialog();
            m_myReader.Close();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //
            int lineCount = 0; // счетчик строк
            float linesPerPage = 0; // количество строк на одной странице
            float yLinePosition = 0; // текущая позиция при печати по
                                     // вертикальной оси
            string currentLine = null; // текст текущей строки
                                       // Шрифт для печати текста
            /*???*/
            System.Drawing.Font printFont = this.richTextBox1.Font;
            // Кисть для печати текста
            SolidBrush printBrush = new SolidBrush(Color.Black);
            // Размер отступа слева
            float leftMargin = e.MarginBounds.Left;
            // Размер отступа сверху
            float topMargin = e.MarginBounds.Top +
            3 * printFont.GetHeight(e.Graphics);
            // Вычисляем количество строк на одной странице с учетом отступа
            linesPerPage = (e.MarginBounds.Height - 6 * printFont.GetHeight(e.Graphics)) / printFont.GetHeight(e.Graphics);
            // Цикл печати всех строк страницы
            while (lineCount < linesPerPage &&
            ((currentLine = m_myReader.ReadLine()) != null))
            {
                // Вычисляем позицию очередной распечатываемой строки
                yLinePosition = topMargin + (lineCount *
                printFont.GetHeight(e.Graphics));
                // Печатаем очередную строку
                e.Graphics.DrawString(currentLine, printFont, printBrush,
                leftMargin, yLinePosition, new StringFormat());
                // Переходим к следующей строке
                lineCount++;
            }
            // Если напечатаны не все строки документа,
            // переходим к следующей странице
            if (currentLine != null)
            {
                e.HasMorePages = true;
                m_PrintPageNumber++;
            }
            // Иначе завершаем печать страницы
            else
                e.HasMorePages = false;
            // Освобождаем ненужные более ресурсы
            printBrush.Dispose();
        }
        //Меню Панель інструментів
        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docChanged)
            {
                DialogResult dr;
                dr = MessageBox.Show(
                "Зберегти зміни?", "NkEdit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (SaveDocument() == 0)
                        {
                            NewDocument();
                            docChanged = false;
                        }
                        break;
                    case DialogResult.No:
                        NewDocument();
                        docChanged = false;
                        break;
                    case DialogResult.Cancel:
                        break;
                };
            }
            else
            {
                NewDocument();
            }
        }
        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }
        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }
        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocumentAs();
        }
        private void друкуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument();
        }
        private void попереднійПереглядToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //організація попереднього перегляду
            m_PrintPageNumber = 1;
            string strText = this.richTextBox1.Text;
            m_myReader = new StringReader(strText);
            Margins margins = new Margins(100, 50, 50, 50);
            printDocument1.DefaultPageSettings.Margins = margins;
            printPreviewDialog1.ShowDialog();
            m_myReader.Close();
        }
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Завершення роботи - перевірити чи збережені зміни у файлі
            if (docChanged)
            {
                DialogResult dr;
                dr = MessageBox.Show(" Зберегти зміни?", " NkEdit ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        SaveDocument();
                        this.Close();
                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                    case DialogResult.Cancel:
                        // відмінити закриття вікна програми
                        break;
                };
            }
            this.Close();
        }
        private void мояДовідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 myform = new AboutBox1();
            myform.ShowDialog();
        }
    }
}

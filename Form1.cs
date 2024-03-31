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
        private StringReader m_myReader; //���� ��� ���������� ����
        private int m_PrintPageNumber; //������� ������� ��� �����

        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = string.Empty;
            richTextBox1.Font = fontDialog1.Font;
            this.Text = "NkEdit - ����� ��������";
            // ������� ������ ������������
            toolStrip1.Visible = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            openFileDialog1.Title = "³������ ��������";

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "doc1.txt";
            saveFileDialog1.Filter = "(*.txt) | *.txt | All Files(*.*) | *.*";
            saveFileDialog1.Title = " �������� ��������";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear(); //�������� ����� ��������
        }
        private void NewDocument()
        {
            richTextBox1.Clear(); //�������� ����� ��������
            fn = string.Empty;
            saveFileDialog1.FileName = "doc1.txt";
        }
        private void OpenDocument()
        {
            openFileDialog1.FileName = string.Empty;
            // ³��������� ����� �������� �����
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn = openFileDialog1.FileName;
                // ���������� ��'� ����� � ��������� ����
                this.Text = fn;
                try
                {
                    // ������� ����� � �����
                    System.IO.StreamReader sr = new System.IO.StreamReader(fn);
                    richTextBox1.Text = sr.ReadToEnd();
                    richTextBox1.SelectionStart = richTextBox1.TextLength;
                    sr.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(" ������� ������� �����.\n " + exc.ToString(), " NkEdit ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int SaveDocument()
        {
            int result = 0;
            if (fn == string.Empty)
            {
                // ���������� ����� ��������
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fn = saveFileDialog1.FileName;
                    // ���������� ��&#39;� ����� � ��������� ����
                    this.Text = fn;
                }
                else result = -1;
            }
            // �������� ����
            if (fn != string.Empty)
            {
                try
                {
                    // �������� ���������� ��� ���� fn
                    System.IO.FileInfo fi = new System.IO.FileInfo(fn);
                    // ��������� ���� ��� ������ (������������ ����)
                    System.IO.StreamWriter sw = fi.CreateText();
                    // �������� ���
                    sw.Write(richTextBox1.Text);
                    // ��������� ����
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
            // ���������� ����� ��������
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn = saveFileDialog1.FileName;
                // ���������� ��&#39;� ����� � ��������� ����
                this.Text = fn;
            }
            try
            {
                // �������� ���������� ��� ���� fn
                System.IO.FileInfo fi = new System.IO.FileInfo(fn);
                // ��������� ���� ��� ������ (������������ ����)
                System.IO.StreamWriter sw = fi.CreateText();
                // �������� ���
                sw.Write(richTextBox1.Text);
                // ��������� ����
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
            //���������� �����
            m_PrintPageNumber = 1;
            string strText = this.richTextBox1.Text;
            m_myReader = new StringReader(strText);
            printDialog1.ShowDialog();
            m_myReader.Close();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //
            int lineCount = 0; // ������� �����
            float linesPerPage = 0; // ���������� ����� �� ����� ��������
            float yLinePosition = 0; // ������� ������� ��� ������ ��
                                     // ������������ ���
            string currentLine = null; // ����� ������� ������
                                       // ����� ��� ������ ������
            /*???*/
            System.Drawing.Font printFont = this.richTextBox1.Font;
            // ����� ��� ������ ������
            SolidBrush printBrush = new SolidBrush(Color.Black);
            // ������ ������� �����
            float leftMargin = e.MarginBounds.Left;
            // ������ ������� ������
            float topMargin = e.MarginBounds.Top +
            3 * printFont.GetHeight(e.Graphics);
            // ��������� ���������� ����� �� ����� �������� � ������ �������
            linesPerPage = (e.MarginBounds.Height - 6 * printFont.GetHeight(e.Graphics)) / printFont.GetHeight(e.Graphics);
            // ���� ������ ���� ����� ��������
            while (lineCount < linesPerPage &&
            ((currentLine = m_myReader.ReadLine()) != null))
            {
                // ��������� ������� ��������� ��������������� ������
                yLinePosition = topMargin + (lineCount *
                printFont.GetHeight(e.Graphics));
                // �������� ��������� ������
                e.Graphics.DrawString(currentLine, printFont, printBrush,
                leftMargin, yLinePosition, new StringFormat());
                // ��������� � ��������� ������
                lineCount++;
            }
            // ���� ���������� �� ��� ������ ���������,
            // ��������� � ��������� ��������
            if (currentLine != null)
            {
                e.HasMorePages = true;
                m_PrintPageNumber++;
            }
            // ����� ��������� ������ ��������
            else
                e.HasMorePages = false;
            // ����������� �������� ����� �������
            printBrush.Dispose();
        }
        //���� ������ �����������
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docChanged)
            {
                DialogResult dr;
                dr = MessageBox.Show(
                "�������� ����?", "NkEdit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
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
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }
        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }
        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocumentAs();
        }
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument();
        }
        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���������� ������������ ���������
            m_PrintPageNumber = 1;
            string strText = this.richTextBox1.Text;
            m_myReader = new StringReader(strText);
            Margins margins = new Margins(100, 50, 50, 50);
            printDocument1.DefaultPageSettings.Margins = margins;
            printPreviewDialog1.ShowDialog();
            m_myReader.Close();
        }
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���������� ������ - ��������� �� �������� ���� � ����
            if (docChanged)
            {
                DialogResult dr;
                dr = MessageBox.Show(" �������� ����?", " NkEdit ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
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
                        // ������� �������� ���� ��������
                        break;
                };
            }
            this.Close();
        }
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 myform = new AboutBox1();
            myform.ShowDialog();
        }
    }
}

using System.Drawing.Printing;
using System.Windows.Forms;

namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новийToolStripMenuItem = new ToolStripMenuItem();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            друкуватиToolStripMenuItem = new ToolStripMenuItem();
            попереднійПереглядToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            параметриToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            допомогаToolStripMenuItem = new ToolStripMenuItem();
            мояДовідкаToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            создатьToolStripButton = new ToolStripButton();
            открытьToolStripButton = new ToolStripButton();
            сохранитьToolStripButton = new ToolStripButton();
            печатьToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            printDocument1 = new PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            pageSetupDialog1 = new PageSetupDialog();
            printDialog1 = new PrintDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, параметриToolStripMenuItem, допомогаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новийToolStripMenuItem, відкритиToolStripMenuItem, зберегтиToolStripMenuItem, зберегтиЯкToolStripMenuItem, toolStripMenuItem2, друкуватиToolStripMenuItem, попереднійПереглядToolStripMenuItem, toolStripMenuItem3, вихідToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // новийToolStripMenuItem
            // 
            новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            новийToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            новийToolStripMenuItem.Size = new Size(241, 22);
            новийToolStripMenuItem.Text = "Новий";
            новийToolStripMenuItem.Click += новийToolStripMenuItem_Click;
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            відкритиToolStripMenuItem.Size = new Size(241, 22);
            відкритиToolStripMenuItem.Text = "Відкрити...";
            відкритиToolStripMenuItem.Click += відкритиToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            зберегтиToolStripMenuItem.Size = new Size(241, 22);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            зберегтиЯкToolStripMenuItem.Size = new Size(241, 22);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як ...";
            зберегтиЯкToolStripMenuItem.Click += зберегтиЯкToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(241, 22);
            toolStripMenuItem2.Text = "----------";
            // 
            // друкуватиToolStripMenuItem
            // 
            друкуватиToolStripMenuItem.Name = "друкуватиToolStripMenuItem";
            друкуватиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            друкуватиToolStripMenuItem.Size = new Size(241, 22);
            друкуватиToolStripMenuItem.Text = "Друкувати...";
            друкуватиToolStripMenuItem.Click += друкуватиToolStripMenuItem_Click;
            // 
            // попереднійПереглядToolStripMenuItem
            // 
            попереднійПереглядToolStripMenuItem.Name = "попереднійПереглядToolStripMenuItem";
            попереднійПереглядToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            попереднійПереглядToolStripMenuItem.Size = new Size(241, 22);
            попереднійПереглядToolStripMenuItem.Text = "Попередній перегляд...";
            попереднійПереглядToolStripMenuItem.Click += попереднійПереглядToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(241, 22);
            toolStripMenuItem3.Text = "----------";
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(241, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // параметриToolStripMenuItem
            // 
            параметриToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { шрифтToolStripMenuItem });
            параметриToolStripMenuItem.Name = "параметриToolStripMenuItem";
            параметриToolStripMenuItem.Size = new Size(81, 20);
            параметриToolStripMenuItem.Text = "Параметри";
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(180, 22);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // допомогаToolStripMenuItem
            // 
            допомогаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { мояДовідкаToolStripMenuItem });
            допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            допомогаToolStripMenuItem.Size = new Size(75, 20);
            допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // мояДовідкаToolStripMenuItem
            // 
            мояДовідкаToolStripMenuItem.Name = "мояДовідкаToolStripMenuItem";
            мояДовідкаToolStripMenuItem.Size = new Size(141, 22);
            мояДовідкаToolStripMenuItem.Text = "Моя довідка";
            мояДовідкаToolStripMenuItem.Click += мояДовідкаToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { создатьToolStripButton, открытьToolStripButton, сохранитьToolStripButton, печатьToolStripButton, toolStripSeparator });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // создатьToolStripButton
            // 
            создатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            создатьToolStripButton.Image = (Image)resources.GetObject("создатьToolStripButton.Image");
            создатьToolStripButton.ImageTransparentColor = Color.Magenta;
            создатьToolStripButton.Name = "создатьToolStripButton";
            создатьToolStripButton.Size = new Size(23, 22);
            создатьToolStripButton.Text = "&Создать";
            создатьToolStripButton.Click += новийToolStripMenuItem_Click;
            // 
            // открытьToolStripButton
            // 
            открытьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            открытьToolStripButton.Image = (Image)resources.GetObject("открытьToolStripButton.Image");
            открытьToolStripButton.ImageTransparentColor = Color.Magenta;
            открытьToolStripButton.Name = "открытьToolStripButton";
            открытьToolStripButton.Size = new Size(23, 22);
            открытьToolStripButton.Text = "&Открыть";
            открытьToolStripButton.Click += відкритиToolStripMenuItem_Click;
            // 
            // сохранитьToolStripButton
            // 
            сохранитьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            сохранитьToolStripButton.Image = (Image)resources.GetObject("сохранитьToolStripButton.Image");
            сохранитьToolStripButton.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            сохранитьToolStripButton.Size = new Size(23, 22);
            сохранитьToolStripButton.Text = "&Сохранить";
            сохранитьToolStripButton.Click += зберегтиToolStripMenuItem_Click;
            // 
            // печатьToolStripButton
            // 
            печатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            печатьToolStripButton.Image = (Image)resources.GetObject("печатьToolStripButton.Image");
            печатьToolStripButton.ImageTransparentColor = Color.Magenta;
            печатьToolStripButton.Name = "печатьToolStripButton";
            печатьToolStripButton.Size = new Size(23, 22);
            печатьToolStripButton.Text = "&Печать";
            печатьToolStripButton.Click += друкуватиToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 401);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Мій редактор тексту";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem новийToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem друкуватиToolStripMenuItem;
        private ToolStripMenuItem параметриToolStripMenuItem;
        private ToolStripMenuItem допомогаToolStripMenuItem;
        private ToolStripMenuItem попереднійПереглядToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem мояДовідкаToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton создатьToolStripButton;
        private ToolStripButton открытьToolStripButton;
        private ToolStripButton сохранитьToolStripButton;
        private ToolStripButton печатьToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox richTextBox1;
    }
}

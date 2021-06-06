using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HolyPad
{
    public partial class Form1 : Form
    {
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPath = new OpenFileDialog();
            openPath.Title = "Open a file..";
            if (openPath.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                using (StreamReader sr = new StreamReader(openPath.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    
                }
                filePath = openPath.FileName;
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                filePath = saveFile1.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

                if (string.IsNullOrEmpty(filePath))
                {
                    SaveFileDialog saveFile1 = new SaveFileDialog();
                    saveFile1.DefaultExt = "*.txt";
                    saveFile1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                        saveFile1.FileName.Length > 0)
                    {
                        filePath = saveFile1.FileName;
                    }
                    else return;
                }

                try
                {
                    richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                }
                catch (Exception)
                {
                    // Put exception handling code here
                }
            

        }
    
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "HolyPad is a remake of Window's 10 Notepad..\nWhile it is a remake I am still quite fond of it!";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            saved.Text = "New Text File Made..";
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                filePath = saveFile1.FileName;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            saved.Text = "Text file opened..";
            OpenFileDialog openPath = new OpenFileDialog();
            openPath.Title = "Open a file..";
            if (openPath.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                using (StreamReader sr = new StreamReader(openPath.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();

                }
                filePath = openPath.FileName;
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            saved.Text = "Text File Saved..";
            if (string.IsNullOrEmpty(filePath))
            {

                SaveFileDialog saveFile1 = new SaveFileDialog();
                saveFile1.DefaultExt = "*.txt";
                saveFile1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                    saveFile1.FileName.Length > 0)
                {
                    filePath = saveFile1.FileName;
                }
                else return;
            }

            try
            {
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
            }
            catch (Exception)
            {
                // Put exception handling code here
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            saved.Text = "Text File Saved";
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                filePath = saveFile1.FileName;
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "HolyPad is a remake of Window's 10 Notepad..\nWhile it is a remake I am still quite fond of it!";

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saved_Click(object sender, EventArgs e)
        {

        }
    }

}

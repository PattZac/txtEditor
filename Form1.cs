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

namespace txtEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void bntNew_Click(object sender, EventArgs e)
        {
            txtBoxInputText.Clear();
            txtBoxInputText.Focus();
        }

        private void bntOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Plain Text files (*.txt)|*.txt|Rich Text files (*.rtf)|*.rtf";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                RichTextBoxStreamType stream_type;
                stream_type = RichTextBoxStreamType.RichText;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(openFileDialog.FileName))
                    {
                        return;
                    }
                    if (openFileDialog.FilterIndex==1)
                    {
                        stream_type = RichTextBoxStreamType.PlainText;
                    }
                    txtBoxInputText.LoadFile(openFileDialog.FileName, stream_type);
                }
            }
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Plain Text files (*.txt)|*.txt|Rich Text files (*.rtf)|*.rtf";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType stream_type;
                if (saveFileDialog1.FilterIndex==1)
                {
                    stream_type = RichTextBoxStreamType.PlainText;
                }
                else
                {
                    stream_type = RichTextBoxStreamType.RichText;
                }
                try
                {
                    txtBoxInputText.SaveFile(saveFileDialog1.FileName, stream_type);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Pogrešan u .txt file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void bntBold_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = txtBoxInputText.SelectionFont;
            if (SelectedText_Font != null)
            {
                txtBoxInputText.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);
            }
        }

        private void bntItalic_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = txtBoxInputText.SelectionFont;
            if (SelectedText_Font != null)
            {
                txtBoxInputText.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Italic);
            }
        }

        private void bntUnderline_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = txtBoxInputText.SelectionFont;
            if (SelectedText_Font != null)
            {
                txtBoxInputText.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Underline);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                bntBold_Click(null, null);
            }
            if (e.Control && e.KeyCode == Keys.I)
            {
                bntItalic_Click(null, null);
            }
            if (e.Control && e.KeyCode == Keys.U)
            {
                bntUnderline_Click(null, null);
            }
        }
    }
}

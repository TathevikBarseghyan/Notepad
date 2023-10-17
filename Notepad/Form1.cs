using System.Data;
using System.Diagnostics;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewToolStrip_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void OpenToolStrip_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            openFileDialog.Filter = "Text Files |*.txt";
            if (dr == DialogResult.OK)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
                this.Text = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStrip_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.Text))
            {
                File.WriteAllText(this.Text, textBox.Text);
            }
            else
            {
                SaveAsToolStrip1_Click(SaveAsToolStrip, EventArgs.Empty);
            }
        }
        private void SaveAsToolStrip1_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit", "Save?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                SaveAsToolStrip1_Click(SaveAsToolStrip, EventArgs.Empty);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ExitToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void DeleteToolStrip_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = colorDialog.Color;
            }
        }

        private void DateTimeToolStrip_Click(object sender, EventArgs e)
        {
            textBox.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.WordWrap = WordWrapToolStrip.Checked;
            StatusBarToolStrip.Enabled = !WordWrapToolStrip.Checked;
            if (StatusBarToolStrip.Enabled)
                StatusBarToolStrip.Checked = true;

            statusContent.Visible = StatusBarToolStrip.Checked;

        }

        private void WordWrapToolStrip_CheckedChanged(object sender, EventArgs e)
        {
            textBox.WordWrap = WordWrapToolStrip.Checked;
            StatusBarToolStrip.Enabled = !WordWrapToolStrip.Checked;
            StatusBarToolStrip.Checked = true;
            statusContent.Visible = StatusBarToolStrip.Enabled;
        }

        private void StatusBarToolStrip_Click(object sender, EventArgs e)
        {
            statusContent.Visible = StatusBarToolStrip.Checked;
        }

        private void textBox_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            int position = textBox.SelectionStart;
            int line = textBox.GetLineFromCharIndex(position) + 1;
            int column = position - textBox.GetFirstCharIndexOfCurrentLine() + 1;

            status.Text = "Ln " + line + " Col " + column;
        }

        private void ViewHelpToolStrip_Click(object sender, EventArgs e)
        {
            _ = Process.Start(new ProcessStartInfo { FileName = @"https://www.bing.com/search?q=get+help+with+notepad+in+windows&filters=guid:%224466414-en-dia%22%20lang:%22en%22&form=T00032&ocid=HelpPane-BingIA", UseShellExecute = true });
        }

        
    }
}

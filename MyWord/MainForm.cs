using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWord
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var filename = saveFileDialog.FileName;
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.Write(textBox.Text);
                }
            }

        }

        /*private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filename = openFileDialog1.FileName;
            using (StreamReader sr = new StreamReader(filename))
            {
                //sr.Read(textBox.Text);
            }
        }
        */
        protected override void OnClosing(CancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit?", "My Word", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
            base.OnClosing(e);
        }
    }
}

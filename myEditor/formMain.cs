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

namespace myEditor
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    writer.Write(textBox1.Text);
                }
            }

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    textBox1.Text = reader.ReadToEnd();
                }
            }
        }
    }
}

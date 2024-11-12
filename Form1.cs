using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor= Color.Green;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font,label1.Font.Style^FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font,label1.Font.Style^FontStyle.Italic);
        }
    }
}

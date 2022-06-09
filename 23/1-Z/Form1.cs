using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str = (string)listBox1.Items[0];
            label1.Text = string.Concat(str.Where(c => c >= 'а' && c <= 'я' || c == 'ё'));
        }
    }
}

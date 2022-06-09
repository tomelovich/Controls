using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue);
            graph.DrawRectangle(pen, 120, 200, 300, 20);
            graph.DrawRectangle(pen, 100, 50, 20, 330);
            graph.DrawRectangle(pen, 400, 220, 20, 150);
            picture.Image = bmp;
        }
    }
}

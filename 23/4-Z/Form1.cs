using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int k1 = int.Parse(textBox2.Text);
            int k2 = int.Parse(textBox3.Text);
            if (textBox1.Text.ToString() == "К")
            {
                Button button2 = new Button();
                button2.Location = new Point(k1, k2);
                button2.Name = "button1";
                button2.Size = new Size(75, 23);
                button2.TabIndex = 0;
                button2.Text = "Кнопка";
                button2.UseVisualStyleBackColor = true;
                button2.Click += new EventHandler(button1_Click); 
                Controls.Add(button2);
                button2.MouseMove += ctrButton_MouseMove;
            }
            else if (textBox1.Text.ToString() == "П")
            {
                TextBox textBox4 = new TextBox(); 
                textBox4.Location = new Point(k1, k2);
                textBox4.Name = "textBox4";
                textBox4.Size = new Size(75, 23);
                textBox4.TabIndex = 0;
                textBox4.Text = "Поле для ввода";  
                textBox4.Click += new EventHandler(button1_Click); 
                Controls.Add(textBox4);
                textBox4.MouseMove += ctrTextbox_MouseMove;

            }
            else if (textBox1.Text.ToString() == "М")
            {
                Label label3 = new Label(); 
                label3.Location = new Point(k1, k2); 
                label3.Name = "label3";
                label3.Size = new Size(75, 23);
                label3.TabIndex = 0;
                label3.Text = "Метка";
                label3.Click += new EventHandler(button1_Click); 
                Controls.Add(label3);
               label3.MouseMove += ctrLabel_MouseMove;
            }
        }
        private void ctrButton_MouseMove(Object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.Dispose();
        }
        private void ctrTextbox_MouseMove(Object sender, MouseEventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Dispose();
        }
        private void ctrLabel_MouseMove(Object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            l.Dispose();
        }
    }
}

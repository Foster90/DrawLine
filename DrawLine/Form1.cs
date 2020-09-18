using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLine
{
    public partial class Form1 : Form
    {
        Graphics drawarea;
        public Form1()
        {
            InitializeComponent();
            drawarea = drawingArea.CreateGraphics();
        }

        private void btDraw_Click(object sender, EventArgs e)
        {

            int x1, x2, y1, y2;

            x1 = Convert.ToInt32(textx1.Text);
            x2 = Convert.ToInt32(textx2.Text);
            y1 = Convert.ToInt32(texty1.Text);
            y2 = Convert.ToInt32(texty2.Text);




            Brush red = new SolidBrush(Color.Red);
            Pen pn = new Pen(red, 8);
            drawarea.DrawLine(pn, x1, x2, y1, y2);

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

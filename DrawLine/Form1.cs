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

            Brush red = new SolidBrush(Color.Red);
            Pen pn = new Pen(red, 8);
            drawarea.DrawLine(pn, 10, 10, 400, 376);

        }
    }
}

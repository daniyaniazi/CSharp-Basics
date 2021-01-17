using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender,PaintEventArgs e ) {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 4);
            g.DrawLine(p, 0, 0, 250, 250);
            g.DrawEllipse(p, 120, 120, 250, 250);
            g.DrawRectangle(p, 30, 30, 200, 200);
        }
    }
}

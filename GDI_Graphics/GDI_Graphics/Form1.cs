using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            Pen redpen =new Pen(Color.Red, 2);
            g.DrawLine(redpen, 0, 0,250, 250);
            g.DrawEllipse(redpen, 260, 120, 350, 150);
            g.DrawRectangle(redpen, 30, 30, 200, 200);
            Rectangle rt = new Rectangle(50, 50, 200, 100);
            g.DrawArc(redpen, rt, 20, 140);


            Rectangle rect = new Rectangle(150, 310, 100, 100);
            Brush yellowBrush = new SolidBrush(Color.Beige);
            g.FillRectangle(yellowBrush, rect);

            Font fnt = new Font("Verdana", 16, FontStyle.Italic);
            g.DrawString("M YSTRING", fnt, yellowBrush,new Point(0, 20));


        }
    }
}

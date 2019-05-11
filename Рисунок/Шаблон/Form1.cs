using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шаблон
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        Pen pen = new Pen(Color.DarkGray, 2);
        SolidBrush brush = new SolidBrush(Color.Silver);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillEllipse(brush, 100, 50, 175, 75);
            brush.Color = Color.Wheat;
            g.FillRectangle(brush, 90, 78, 195, 20);
            g.FillEllipse(brush, 80, 78, 20, 20);
            g.FillEllipse(brush, 275, 78, 20, 20);
            float[] dashValues = { 5, 5 };
            pen.DashPattern = dashValues;
            g.DrawLine(pen, 180, 130, 140, 400);
            g.DrawLine(pen, 190, 130, 190, 400);
            g.DrawLine(pen, 200, 130, 240, 400);
            brush.Color = Color.LightGreen;
            g.FillRectangle(brush, 0, 410, 1000, 300);
            brush.Color = Color.White;
            Point[] cloud = { new Point(400, 20), new Point(450, 25), new Point(480, 20), new Point(490, 70), new Point(470, 60), new Point(390, 70) };

            g.FillPolygon(brush, cloud);
            PointF[] star = { new PointF(190, 50), new PointF(200, 75), new PointF(178, 60), new PointF(202, 60), new PointF(180, 75), new PointF(190, 50) };
            pen.Color = Color.Black;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            g.DrawLines(pen, star);



            //g.Clear(Color.White);
            //for (int i = 0; i < 50; i++)
            //    g.DrawLine(new Pen(Brushes.Black, 2),
            //    10, 4 * i + 20, 200, 4 * i + 20);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
            
        }
    }
}

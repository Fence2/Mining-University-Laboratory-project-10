using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вишнёвое_дерево
{
    public partial class Tree : Form
    {
        public Tree()
        {
            InitializeComponent();
            MouseClick += Coordinates;
        }


        private void Tree_Paint(object sender, PaintEventArgs e)
        {
            BackColor = Color.LightBlue;

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Green, 4);
            SolidBrush brush = new SolidBrush(Color.Green);
            //стебли вишни
            Rectangle stick = new Rectangle(160, 109, 251, 465);
            g.DrawArc(pen, stick, -20, -47);
            PointF[] cherry_stick = { new PointF(363, 158), new PointF(366, 189), new PointF(368, 222), new PointF(355, 250), new PointF(335, 304) };
            g.DrawCurve(pen, cherry_stick);
            //ветка
            pen.Color = Color.Brown;
            pen.Width = 6;
            PointF[] tree = { new PointF(150, -5), new PointF(180, 86), new PointF(282, 142), new PointF(493, 175) };
            g.DrawCurve(pen, tree);
            //росточек
            PointF[] yellow = { new PointF(500, 170), new PointF(506, 154), new PointF(518, 154), new PointF(516, 166) };
            brush.Color = Color.Orange;
            g.FillPolygon(brush, yellow);
            //лист
            PointF[] tree_stick = { new PointF(505, 166), new PointF(493, 175), new PointF(508, 190) };
            g.DrawCurve(pen, tree_stick);

            pen.Color = Color.Green;
            PointF[] tree_green_stick = { new PointF(507, 189), new PointF(564, 217), new PointF(652, 231), new PointF(702, 220), new PointF(719, 199) };
            g.DrawCurve(pen, tree_green_stick);
            PointF[] list1 = { new PointF(715, 203), new PointF(763, 189), new PointF(799, 156), new PointF(803, 97), new PointF(787, 41), new PointF(738, 67), new PointF(707, 111), new PointF(706, 167) };
            brush.Color = Color.Green;
            g.FillPolygon(brush, list1);
            PointF[] v_list1 = { new PointF(715, 203), new PointF(760, 126), new PointF(787, 41) };
            pen.Color = Color.LightGreen;
            pen.Width = 2;
            g.DrawCurve(pen, v_list1);
            PointF[] izgib1 = { new PointF(763, 189), new PointF(725, 189), new PointF(706, 167) };
            g.DrawLines(pen, izgib1);
            PointF[] izgib2 = { new PointF(799, 156), new PointF(743, 159), new PointF(707, 111) };
            g.DrawLines(pen, izgib2);
            PointF[] izgib3 = { new PointF(803, 97), new PointF(772, 94), new PointF(738, 67) };
            g.DrawLines(pen, izgib3);

            //вишни
            Rectangle cherry1 = new Rectangle(376, 291, 80, 80);
            brush.Color = Color.DarkRed;
            g.FillEllipse(brush, cherry1);

            Rectangle cherry2 = new Rectangle(290, 298, 80, 80);
            g.FillEllipse(brush, cherry2);

            //трава
            Rectangle ground = new Rectangle(0, 517, 1000, 400);
            brush.Color = Color.LightGreen;
            g.FillRectangle(brush, ground);
            pen.Color = Color.Green;
            int x = 25;
            float[] dashValues = { 4, 4 };
            pen.DashPattern = dashValues;
            while (x < 1000)
            {
                g.DrawLine(pen, x, 515, x - 20, 575);
                x += 30;
            }
            x = 25;
            while (x < 1000)
            {
                g.DrawLine(pen, x, 570, x - 20, 630);
                x += 30;
            }
            x = 25;
            while (x < 1000)
            {
                g.DrawLine(pen, x, 625, x - 20, 685);
                x += 30;
            }
        }
        private void Coordinates(object sender, MouseEventArgs e)
        {
            textBox1.Text += "new PointF(" + e.X.ToString() + ", " + e.Y.ToString() + "), ";
        }
    }
}

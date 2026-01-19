using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Liang–Barsky Line Clipping Algorithm
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point p1 = new Point(80, 200);
            Point p2 = new Point(180, 50);

            Rectangle clipRect = new Rectangle(100, 100, 100, 100);

            e.Graphics.DrawLine(Pens.Blue, p1, p2);

            e.Graphics.DrawRectangle(Pens.Black, clipRect);

            BarskyLineClip(ref p1, ref p2, clipRect, e.Graphics);

            e.Graphics.DrawLine(Pens.Red, p1, p2);
        }

        private static void BarskyLineClip(ref Point p1, ref Point p2, Rectangle clipRect, Graphics g)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double tE = 0.0, tL = 1.0;

            if (ClipTest(-dx, p1.X - clipRect.Left, ref tE, ref tL))
            {
                if (ClipTest(dx, clipRect.Right - p1.X, ref tE, ref tL))
                {
                    if (ClipTest(-dy, p1.Y - clipRect.Top, ref tE, ref tL))
                    {
                        if (ClipTest(dy, clipRect.Bottom - p1.Y, ref tE, ref tL))
                        {
                            if (tL < 1.0)
                            {
                                p2.X = (int)(p1.X + tL * dx);
                                p2.Y = (int)(p1.Y + tL * dy);
                            }
                            if (tE > 0.0)
                            {
                                p1.X = (int)(p1.X + tE * dx);
                                p1.Y = (int)(p1.Y + tE * dy);
                            }
                        }
                    }
                }
            }
        }

        private static bool ClipTest(double p, double q, ref double tE, ref double tL)
        {
            double r;

            if (p < 0.0)
            {
                r = q / p;
                if (r > tL)
                    return false;
                else if (r > tE)
                    tE = r;
            }
            else if (p > 0.0)
            {
                r = q / p;
                if (r < tE)
                    return false;
                else if (r < tL)
                    tL = r;
            }
            else
            {
                if (q < 0.0)
                    return false;
            }

            return true;
        }
    }
}

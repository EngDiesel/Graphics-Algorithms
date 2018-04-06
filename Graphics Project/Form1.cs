using System;
using System.Drawing;
using System.Windows.Forms;


namespace Graphics_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Pen p;
        
        /// <summary>
        /// Digital Deffrence Analyzer Method 
        /// </summary>
        /// <param Start Horizenol ="Xs"></param>
        /// <param Start Verticle ="Ys"></param>
        /// <param End Horizenol="Xe"></param>
        /// <param End Verticle="Ye"></param>
        private void DDA(int Xs, int Ys, int Xe, int Ye)
        {
            
            pnlGraphics.BorderStyle = BorderStyle.FixedSingle;
            g = pnlGraphics.CreateGraphics();
            p = new Pen(Color.Blue, 1);

            int dx = Xe - Xs, dy = Ye - Ys, steps, k;
            float xInc, yInc, X = Xs, Y = Ys;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);

            xInc = dx / (float) steps;
            yInc = dy / (float)steps;

            double x = Math.Round(X );
            double y = Math.Round(Y);


            g.DrawRectangle(p, (int)x, (int)y, 1, 1);

            for (k = 0; k < steps; k++)
            {
                X += xInc;
                Y += yInc;

                x = Math.Round(X + 0.5);
                y = Math.Round(Y + 0.5);

                g.DrawRectangle(p, (int)x, (int)y, 1, 1);
            }

        }
    
        /// <summary>
        /// Bresenham Line Drawing Algorithm
        /// </summary>
        /// <param name="Xs">X Axis for Start Point</param>
        /// <param name="Ys">Y Axis for Start Point</param>
        /// <param name="Xe">X Axis for End Point</param>
        /// <param name="Ye">Y Axis for End Point</param>
        private void Bresenham(int Xs, int Ys, int Xe, int Ye)
        {
            pnlGraphics.BorderStyle = BorderStyle.FixedSingle;
            g = pnlGraphics.CreateGraphics();
            p = new Pen(Color.Blue, 1);

            g.DrawRectangle(p, Xs, Ys, 1, 1);

            int dy = Ye - Ys, dx = Xe - Xs, P = 2 * dy - dx, count;


            if (dx > dy) count = dx;
            else count = dy;

            //(dx > dy) ? count = dx : count = dy;

            while (count >= 0)
            {
                if (P < 0)
                {
                    Xs += 1;
                    g.DrawRectangle(p, Xs, Ys, 1, 1);
                    P = P + 2 * dy;
                }
                else
                {
                    Xs += 1; Ys += 1;
                    g.DrawRectangle(p, Xs, Ys, 1, 1);
                    P = P + 2 * dy - 2 * dx;
                }
                count--;
            }
        }

        /// <summary>
        /// Circle Drawing Algorithm
        /// </summary>
        /// <param name="x0">Center X Axis</param>
        /// <param name="y0">Center Y Axis</param>
        /// <param name="radius">Radius by pixils</param>
        private void Circle(int x0, int y0 , int radius)
        {
            pnlGraphics.BorderStyle = BorderStyle.FixedSingle;
            g = pnlGraphics.CreateGraphics();
            p = new Pen(Color.Red, 1);

            int x = radius;
            int y = 0;
            int err = 1 - radius;

            while (x >= y)
            {

                g.DrawRectangle(p, x0 + x, y0 + y, 1, 1);
                g.DrawRectangle(p, x0 + y, y0 + x, 1, 1);
                g.DrawRectangle(p, x0 - y, y0 + x, 1, 1);
                g.DrawRectangle(p, x0 - x, y0 + y, 1, 1);
                g.DrawRectangle(p, x0 - y, y0 - x, 1, 1);
                g.DrawRectangle(p, x0 + y, y0 - x, 1, 1);
                g.DrawRectangle(p, x0 + x, y0 - y, 1, 1);
                g.DrawRectangle(p, x0 - x, y0 - y, 1, 1);


                if (err <= 0)
                {
                    err += 2 * (y + 1) + 1;
                }
                else
                {
                    err = err + (2 * (y + 1)) - (2 * (x - 1)) + 1;
                    x--;
                }
                y++;
            }

        }
        
        /// <summary>
        /// Ellipse Drawing Algorithm
        /// </summary>
        private void Ellipse(Point c, int rx, int ry) 
        {
            pnlGraphics.BorderStyle = BorderStyle.FixedSingle;
            g = pnlGraphics.CreateGraphics();
            p = new Pen(Color.Red, 1);

            int x = 0, y = ry;
            double P = Math.Pow(ry, 2) - (Math.Pow(rx, 2) * ry) + 0.25 * Math.Pow(rx, 2);

            double dx = 2 * Math.Pow(ry, 2) * x;
            double dy = 2 * Math.Pow(rx, 2) * y;


            do
            {
                g.DrawRectangle(p, c.X + x, c.Y + y, 1, 1);
                g.DrawRectangle(p, c.X - x, c.Y - y, 1, 1);
                g.DrawRectangle(p, c.X + x, c.Y - y, 1, 1);
                g.DrawRectangle(p, c.X - x, c.Y + y, 1, 1);

                if (P < 0)
                {
                    x++;
                    dx += 2 * Math.Pow(ry, 2);
                    P += (2 * Math.Pow(ry, 2) * x) + (3 * Math.Pow(ry, 2));
                }
                else
                {
                    x++; y--;
                    dx += 2 * Math.Pow(ry, 2);
                    dy -= 2 * Math.Pow(rx, 2);
                    P += dx - dy + Math.Pow(ry, 2);
                }
            } while (dx < dy);

            double P2 = Math.Pow(ry, 2) * Math.Pow(x, 2) + x * Math.Pow(ry, 2) + (Math.Pow(ry, 2) / 4) + Math.Pow(rx, 2) * Math.Pow(y, 2) - 2 * y * Math.Pow(rx, 2) - Math.Pow(rx, 2) - Math.Pow(rx, 2) * Math.Pow(ry, 2);

            do
            {
                g.DrawRectangle(p, c.X + x, c.Y + y, 1, 1);
                g.DrawRectangle(p, c.X - x, c.Y - y, 1, 1);
                g.DrawRectangle(p, c.X + x, c.Y - y, 1, 1);
                g.DrawRectangle(p, c.X - x, c.Y + y, 1, 1);

                if(P2 > 0)
                {
                    y = y - 1;
                    dy -= 2 * Math.Pow(rx, 2);
                    P2 -= dy + Math.Pow(rx, 2);
                }
                else
                {
                    x++; y--;
                    dx += 2 * Math.Pow(ry, 2);
                    dy -= 2 * Math.Pow(rx, 2);

                    P2 += dx - dy + Math.Pow(rx, 2);
                }

            } while (y > 0);
        }


        /// <summary>
        /// Drawing Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDraw_Click(object sender, EventArgs e)
        {
           
            DDA(50,50,99,99);

            Bresenham(200,20,300,60);

            Circle(100, 100, 51);

            Ellipse(new Point(100, 100), 90, 70);

        }

        /// <summary>
        /// Clear The Drawing Area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Snow);
        }
    }
}

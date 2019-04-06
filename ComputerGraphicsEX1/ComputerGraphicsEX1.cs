using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGraphicsEX1
{
    public partial class ComputerGraphicsEX1 : Form
    {
        Bitmap bitmapImage;

        //Drawing color
        Color color;

        //Mouse click points
        Point firstPoint, secondPoint;

        //Booleans to check if we have 2 points in order to draw line / circle.
        bool IsPoint1Available, IsPoint2Available;

        // Booleans to check what we need to draw
        bool IsDrawingLine, IsDrawingCircle, IsDrawingBazierCurve;

        public ComputerGraphicsEX1()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
            color = Color.Black;     
            IsPoint1Available = IsPoint2Available = false;
            IsDrawingLine = true;
            IsDrawingCircle = false;
            IsDrawingBazierCurve = false;
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            IsDrawingLine = true;
            IsDrawingCircle = false;
            IsDrawingBazierCurve = false;
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            IsDrawingLine = false;
            IsDrawingCircle = true;
            IsDrawingBazierCurve = false;
        }

        private void BazierCurveBtn_Click(object sender, EventArgs e)
        {
            IsDrawingLine = false;
            IsDrawingCircle = false;
            IsDrawingBazierCurve = true;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if(IsPoint1Available == false)
            {
                firstPoint.X = e.X;
                firstPoint.Y = e.Y;
                IsPoint1Available = true;
            }
            else if(IsPoint2Available == false)
            {
                secondPoint.X = e.X;
                secondPoint.Y = e.Y;

                IsPoint2Available = true;
                if (IsDrawingLine == true)
                    DrawLine(firstPoint, secondPoint);
                else if (IsDrawingCircle == true)
                    DrawCircle(firstPoint, secondPoint);

                IsPoint1Available = false;
                IsPoint2Available = false;
            }

            Refresh();
        }

        private void DrawLine(Point source, Point target)
        {
            //Calculating delta X & delta Y
            int deltaX = Math.Abs(target.X - source.X);
            int deltaY = Math.Abs(target.Y - source.Y);

            //Calculate Error
            double err = (deltaY/ deltaX) - 0.5;
            err += (deltaY / deltaX);

            //Improve algorithm to use only integers
            int errp = Convert.ToInt32(2 * deltaX * err);

            //Draw line points
            for (int x = source.X, y = source.Y; x <= target.X; x++)
            {
                bitmapImage.SetPixel(x, y, color);
                if(errp >= 0)
                {
                    y++;
                    errp -=  2 * deltaX;
                }

                errp += 2 * deltaY;
            }
        }

        private void DrawCirclePoints(Point center, int x, int y)
        {
            bitmapImage.SetPixel(center.X + x, center.Y + y, color);
            bitmapImage.SetPixel(center.X - x, center.Y + y, color);
            bitmapImage.SetPixel(center.X + x, center.Y - y, color);
            bitmapImage.SetPixel(center.X - x, center.Y - y, color);
            bitmapImage.SetPixel(center.X + y, center.Y + x, color);
            bitmapImage.SetPixel(center.X - y, center.Y + x, color);
            bitmapImage.SetPixel(center.X + y, center.Y - x, color);
            bitmapImage.SetPixel(center.X - y, center.Y - x, color);
        }

        private void DrawCircle(Point center, Point targetRadius)
        {
            //Calculating delta X & delta Y
            int deltaX = Math.Abs(targetRadius.X - center.X);
            int deltaY = Math.Abs(targetRadius.Y - center.Y);

            int radius = Convert.ToInt32(Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2)));
            int x = 0;
            int y = radius;
            int p = 3 - 2 * radius;
            while(x < y)
            {
                DrawCirclePoints(center, x, y);
                if (p < 0)
                    p += 4 * x + 6;
                else
                {
                    p += 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }

            if(x == y)
                DrawCirclePoints(center, x, y);
        }

        /* Change drawing color functions */
        private void BlueBtn_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void RedBtn_Click(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void GreenBtn_Click(object sender, EventArgs e)
        {
            color = Color.Lime;
        }

        private void YellowBtn_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
        }

        private void BlackBtn_Click(object sender, EventArgs e)
        {
            color = Color.Black;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmapImage, 0, 0);
        }
    }
}

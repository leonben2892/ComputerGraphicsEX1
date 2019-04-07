using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Leon Benjamin - 203550884
//Matan Nabatian - 304865215

namespace ComputerGraphicsEX1
{
    public partial class ComputerGraphicsEX1 : Form
    {
        Bitmap bitmapImage;

        //Drawing color
        Color color;

        //Number of lines for bezier curve
        int numOfLines;

        //Mouse click points
        Point firstPoint, secondPoint, thirdPoint, fourthPoint;

        //Booleans to check if we have 2 points in order to draw line / circle.
        bool IsPoint1Available, IsPoint2Available, IsPoint3Available, IsPoint4Available;

        // Booleans to check what we need to draw
        bool IsDrawingLine, IsDrawingCircle, IsDrawingBezierCurve;

        public ComputerGraphicsEX1()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
            color = Color.Black;     
            IsPoint1Available = IsPoint2Available = IsPoint3Available = IsPoint4Available = false;
            IsDrawingLine = true;
            IsDrawingCircle = false;
            IsDrawingBezierCurve = false;
            NumericBoxLines.Value = 50;
            numOfLines = Convert.ToInt32(NumericBoxLines.Value);           
            LineBtn.Enabled = false;
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
                {
                    DrawLine(firstPoint, secondPoint);
                    IsPoint1Available = false;
                    IsPoint2Available = false;
                }                    
                else if (IsDrawingCircle == true)
                {
                    DrawCircle(firstPoint, secondPoint);
                    IsPoint1Available = false;
                    IsPoint2Available = false;
                }
            }
            else if(IsPoint3Available == false)
            {
                thirdPoint.X = e.X;
                thirdPoint.Y = e.Y;
                IsPoint3Available = true;
            }
            else
            {
                fourthPoint.X = e.X;
                fourthPoint.Y = e.Y;
                IsPoint4Available = true;

                DrawBezierCurve(firstPoint, secondPoint, thirdPoint, fourthPoint);

                IsPoint1Available = false;
                IsPoint2Available = false;
                IsPoint3Available = false;
                IsPoint4Available = false;

            }
            Refresh();
        }

        private void DrawLineHorizontalSlope(int x, int y, int deltaX, int deltaY, int absDeltaX, int absDeltaY, int endX, int errpX)
        {
            // Calculate & draw line points
            for (int i = 0; x < endX; i++)
            {
                x = x + 1;
                if (errpX < 0)
                    errpX += 2 * absDeltaY;
                else
                {
                    if ((deltaX < 0 && deltaY < 0) || (deltaX > 0 && deltaY > 0))
                        y = y + 1;
                    else
                        y = y - 1;
                    errpX += 2 * (absDeltaY - absDeltaX);
                }
                // Draw pixel at (x,y) point
                bitmapImage.SetPixel(x, y, color);
            }
        }

        private void DrawLineVerticalSlope(int x, int y, int deltaX, int deltaY, int absDeltaX, int absDeltaY, int endY, int errpY)
        {
            // Calculate & draw line points
            for (int i = 0; y < endY; i++)
            {
                y = y + 1;
                if (errpY < 0)
                    errpY += 2 * absDeltaX;
                else
                {
                    if ((deltaX < 0 && deltaY < 0) || (deltaX > 0 && deltaY > 0))
                        x = x + 1;
                    else
                        x = x - 1;
                    errpY += 2 * (absDeltaX - absDeltaY);
                }
                // Draw pixel at (x,y) point
                bitmapImage.SetPixel(x, y, color);
            }
        }

        private void DrawLine(Point source, Point target)
        {
            //Required variables for proper line drawing
            int x, y, endX, endY;

            //Calculating delta X & delta Y
            int deltaX = target.X - source.X;
            int deltaY = target.Y - source.Y;

            //Calculating absolute deltaX & delta Y
            int absDeltaX = Math.Abs(deltaX);
            int absDeltaY = Math.Abs(deltaY);

            //Calculate error for both axis in order to be able to draw lines with horizontal & vertical slope
            int errpX = 2 * absDeltaY - absDeltaX;
            int errpY = 2 * absDeltaX - absDeltaY;

            //Bigger slope on X axis
            if (absDeltaX > absDeltaY)
            {
                //Line is left to right
                if (deltaX >= 0)
                {
                    x = source.X;
                    y = source.Y;
                    endX = target.X;
                }
                //Line is right to left
                else
                {
                    x = target.X;
                    y = target.Y;
                    endX = source.X;
                }

                //Calculate & draw line points
                DrawLineHorizontalSlope(x, y, deltaX, deltaY, absDeltaX, absDeltaY, endX, errpX);
            }
            //Bigger slope on Y axis
            else
            {
                //Line is bottom to top
                if (deltaY >= 0)
                {
                    x = source.X;
                    y = source.Y;
                    endY = target.Y;
                }
                //Line is top to bottom
                else
                {
                    x = target.X;
                    y = target.Y;
                    endY = source.Y;
                }

                //Calculate & draw line points
                DrawLineVerticalSlope(x, y, deltaX, deltaY, absDeltaX, absDeltaY, endY, errpY);
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

        private void DrawBezierCurve(Point one, Point two, Point three, Point four)
        {
            //Current calculated point
            double currentX, currentY;

            //Current base point
            Point basePoint = new Point(one.X, one.Y);

            //Next Point
            Point nextPoint = new Point();

            //Calculating a,b,c,d parameters for X
            int aX = -one.X + 3 * two.X - 3 * three.X + four.X;
            int bX = 3 * one.X - 6 * two.X + 3 * three.X;
            int cX = -3 * one.X + 3 * two.X;
            int dX = one.X;

            //Calculating a,b,c,d parameters for Y
            int aY = -one.Y + 3 * two.Y - 3 * three.Y + four.Y;
            int bY = 3 * one.Y - 6 * two.Y + 3 * three.Y;
            int cY = -3 * one.Y + 3 * two.Y;
            int dY = one.Y;

            for (double t = 0; t <= 1; t += (double)1/numOfLines)
            {
                currentX = aX * Math.Pow(t, 3) + bX * Math.Pow(t, 2) + cX * t + dX;
                currentY = aY * Math.Pow(t, 3) + bY * Math.Pow(t, 2) + cY * t + dY;
                nextPoint.X = Convert.ToInt32(currentX);
                nextPoint.Y = Convert.ToInt32(currentY);
                DrawLine(basePoint, nextPoint);
                basePoint = nextPoint;
            }

            //Completion of missing line
            DrawLine(basePoint, four);
        }

        /* Change drawing color functions */
        private void BlueBtn_Click(object sender, EventArgs e){color = Color.Blue;}
        private void RedBtn_Click(object sender, EventArgs e){color = Color.Red;}
        private void GreenBtn_Click(object sender, EventArgs e){color = Color.Lime;}
        private void YellowBtn_Click(object sender, EventArgs e){color = Color.Yellow;}
        private void BlackBtn_Click(object sender, EventArgs e){color = Color.Black;}

        /* Change what needs to be drawn */
        private void LineBtn_Click(object sender, EventArgs e)
        {
            IsDrawingLine = true;
            IsDrawingCircle = false;
            IsDrawingBezierCurve = false;
            LineBtn.Enabled = false;
            CircleBtn.Enabled = true;
            BezierCurveBtn.Enabled = true;
            if(IsPoint1Available == true)
            {
                IsPoint1Available = false;
                IsPoint2Available = false;
                IsPoint3Available = false;
                IsPoint4Available = false;
            }
        }
        private void CircleBtn_Click(object sender, EventArgs e){
            IsDrawingLine = false;
            IsDrawingCircle = true;
            IsDrawingBezierCurve = false;
            LineBtn.Enabled = true;
            CircleBtn.Enabled = false;
            BezierCurveBtn.Enabled = true;
            if (IsPoint1Available == true)
            {
                IsPoint1Available = false;
                IsPoint2Available = false;
                IsPoint3Available = false;
                IsPoint4Available = false;
            }
        }
        private void BezierCurveBtn_Click(object sender, EventArgs e){
            IsDrawingLine = false;
            IsDrawingCircle = false;
            IsDrawingBezierCurve = true;
            LineBtn.Enabled = true;
            CircleBtn.Enabled = true;
            BezierCurveBtn.Enabled = false;
            if (IsPoint1Available == true)
            {
                IsPoint1Available = false;
                IsPoint2Available = false;
                IsPoint3Available = false;
                IsPoint4Available = false;
            }
        }

        //Change number of lines for bezier curve
        private void NumericBoxLines_ValueChanged(object sender, EventArgs e){numOfLines = Convert.ToInt32(NumericBoxLines.Value);}

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmapImage, 0, 0);
        }
    }
}

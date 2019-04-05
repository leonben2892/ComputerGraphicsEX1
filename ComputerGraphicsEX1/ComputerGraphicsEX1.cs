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
        int x0, y0;
        Bitmap bitmapImage;
        bool IsDrawingLine, IsDrawingCircle, IsDrawingBazierCurve;

        public ComputerGraphicsEX1()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
            IsDrawingLine = true;
            IsDrawingCircle = false;
            IsDrawingBazierCurve = false;
        }

        private void DrawCircle_Click(object sender, EventArgs e)
        {
            IsDrawingLine = false;
            IsDrawingCircle = true;
            IsDrawingBazierCurve = false;
        }

        private void BazierCurve_Click(object sender, EventArgs e)
        {
            IsDrawingLine = false;
            IsDrawingCircle = false;
            IsDrawingBazierCurve = true;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
            bitmapImage.SetPixel(x0, y0, Color.Red);
            Refresh();
        }

        private void DrawLine_Click(object sender, EventArgs e)
        {
            IsDrawingLine = true;
            IsDrawingCircle = false;
            IsDrawingBazierCurve = false;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmapImage, 0, 0);
        }
    }
}

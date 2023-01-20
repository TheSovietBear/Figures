using System;
using System.Drawing;
using System.Security.Policy;
using System.Threading;

namespace Shaper
{
    public partial class Form1 : Form
    {
        int panelY;
        int panelX;
        int panelYDiff;
        int panelXDiff;

        private bool isRectangleGenerated;
        private bool isPolygonGenerated;
        private bool isEllipseGenerated;

        private static readonly Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        Thread th;
        Thread th1;
        Thread th2;
        private void btnRec_Click(object sender, EventArgs e)
        {
            th = new Thread(threadr);
            isRectangleGenerated = true;
            th.Start();
        }
        
        public void threadr()
        {
            while(isRectangleGenerated)
            {
                Calibrate();
                int size;
                if (panelYDiff < panelXDiff)
                {
                    size = panelYDiff / 4;
                }
                else
                {
                    size = panelXDiff / 4;
                }
                
                this.CreateGraphics().DrawRectangle(new Pen(RandomColor(), 4), new Rectangle(new Random().Next(0, this.Width),new Random().Next(0, this.Height), size, size));
                Thread.Sleep(3000);
            }
            MessageBox.Show("Rectangles are ready!");
        }

        private void btnTrg_Click(object sender, EventArgs e)
        {
            th1 = new Thread(threadt);
            isPolygonGenerated = true;
            th1.Start();
        }

        public void threadt()
        {
            while(isPolygonGenerated)
            {
                Calibrate();
                int size;
                if (panelYDiff < panelXDiff)
                {
                    size = panelYDiff / 6;
                }
                else
                {
                    size = panelXDiff / 6;
                }
                FillTriangle(new Point(panelX, panelY), size);
                Thread.Sleep(2000);
            }
            MessageBox.Show("Triangles are ready!");
        }

        private void btnCrc_Click(object sender, EventArgs e)
        {
            th2 = new Thread(threadc);
            isEllipseGenerated = true;
            th2.Start();
        }

        public void threadc()
        {
            while(isEllipseGenerated)
            {
                Calibrate();
                int size;
                if (panelYDiff < panelXDiff)
                {
                    size = panelYDiff / 4;
                }
                else
                {
                    size = panelXDiff / 4;
                }
                this.CreateGraphics().DrawEllipse(new Pen(RandomColor(), 4), new Rectangle(new Random().Next(0, this.Width), new Random().Next(0, this.Height), size, size));
                Thread.Sleep(4000);
            }
            MessageBox.Show("Circles are ready!");
        }

        private Color RandomColor()
        {
            return Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }

        private void FillTriangle(Point p, int size)
        {
            Graphics g = CreateGraphics();
            g.DrawPolygon(new Pen(RandomColor(), 4), new Point[] { p, new Point(p.X - size, p.Y + (int)(size * Math.Sqrt(3))), new Point(p.X + size, p.Y + (int)(size * Math.Sqrt(3))) });
        }
        private void Calibrate()
        {
            panelY = random.Next(0, Height);
            panelX = random.Next(0, Width);
            panelYDiff = Height - panelY;
            panelXDiff = Width - panelX;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isRectangleGenerated = false;
            isPolygonGenerated = false;
            isEllipseGenerated = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Instructions ins = new Instructions();
            Hide();
            ins.Show();
        }
    }
}

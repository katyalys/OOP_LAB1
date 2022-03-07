using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;


namespace laba1_oop
{
    public partial class Form1 : Form
    {
        private Figure figure;
        Graphics graphics;

        private bool paint;

        private float width;

        private Point startPoint;   // coordinates of the starting point
        private Point endPoint;     // coordinates of the endpoint

        private ColorDialog cd = new ColorDialog();
        private Color color;

        public Form1()
        {
            InitializeComponent();

            btColor.BackColor = Color.Black;
            color = Color.Black;
            width = 1;
            paint = false;

            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            graphics = Graphics.FromImage(bitmap);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // user starts drawing
            paint = true;

            // coordinates of the starting point
            startPoint.X = e.X;
            startPoint.Y = e.Y;

            // end point is equal to starting point
            endPoint.X = e.X;
            endPoint.Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (figure != null)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;

                paint = false;

                FigureClass.FigureList.Add(figure);

                figure.StartPoint = startPoint;
                figure.EndPoint = endPoint;
                figure.Drawing(graphics);
                pictureBox1.Refresh();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            width = (float)trackBar1.Value;
            if (figure != null)
            {
                figure.Pen = new Pen(color, width);
            }
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                btColor.BackColor = cd.Color;
                color = cd.Color;

                if (figure != null)
                {
                    figure.Pen = new Pen(color, width);
                }
             }

        }

        private void btLine_Click(object sender, EventArgs e)
        {
            figure = new Line(color, width);
        }

        private void btRectangle_Click(object sender, EventArgs e)
        {
            figure = new Rectangle(color, width);
        }

        private void btSquare_Click(object sender, EventArgs e)
        {
            figure = new Square(color, width);
        }

        private void btInheretedTriangle_Click(object sender, EventArgs e)
        {
            figure = new InheretedTriangle(color, width);
        }

        private void btEllipse_Click(object sender, EventArgs e)
        {
            figure = new Ellipse(color, width);
        }

        private void btCircle_Click(object sender, EventArgs e)
        {
            figure = new Circle(color, width);
        }
    }
}

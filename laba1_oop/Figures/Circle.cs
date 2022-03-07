using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba1_oop
{
    class Circle : Ellipse
    {
        public Circle(Color color, float width) : base(color, width) { }

        public Circle(Color color, float width, Point start, Point end) : base(color, width)
        {
            Point startPoint = new Point(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y));
            Point endPoint = new Point(Math.Max(start.X, end.X), Math.Max(start.Y, end.Y));

            StartPoint = startPoint;
            EndPoint = endPoint;

        }

        public Circle(Color color, float width, int x1, int x2, int y1, int y2) : base(color, width)
        {
            Point startPoint = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            Point endPoint = new Point(Math.Max(x1, x2), Math.Max(y1, y2));

            StartPoint = startPoint;
            EndPoint = endPoint;

        }

        public override void Drawing(Graphics drawing)
        {
            int width = Math.Max(StartPoint.X, EndPoint.X) - Math.Min(StartPoint.X, EndPoint.X);
            // int height = Math.Max(StartPoint.Y, EndPoint.Y) - Math.Min(StartPoint.Y, EndPoint.Y);

            drawing.DrawEllipse(Pen, Math.Min(StartPoint.X, EndPoint.X), Math.Max(StartPoint.Y, EndPoint.Y), width, width);
        }
    }
}

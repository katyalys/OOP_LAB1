using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba1_oop
{
    public class Line : Figure
    {
        public Line(Color color, float width) : base(color, width) { }
        public Line(Color color, float width, int x1, int y1, int x2, int y2) : base(color, width)
        {
            Point startPoint = new Point(x1, y1);
            Point endPoint = new Point(x2, y2);

            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override void Drawing(Graphics drawing)
        {
            drawing.DrawLine(Pen, StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba1_oop
{
    class Triangle : Figure
    {
        public Triangle(Color color, float width) : base(color, width) { }

        protected Point _startPoint;
        protected Point _endPoint;

        public Point[] Vertices { get; set; }

        public override void Drawing(Graphics drawing)
        {
            drawing.DrawPolygon(Pen, Vertices);
        }
    }
}

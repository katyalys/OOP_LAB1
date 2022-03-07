using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba1_oop
{
    public abstract class Figure
    {
        public virtual Point StartPoint { get; set; }

        public virtual Point EndPoint { get; set; }

        public abstract void Drawing(Graphics drawing);

        public Pen Pen { get; set; }

        public Figure(Color color, float width)
        {
              Pen = new Pen(color, width);
        }

    }
}

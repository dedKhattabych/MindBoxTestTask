using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestTask.Shapes
{
    public class Square : Rectangle // по LSP
    {
        public double Side => Width;
        public Square(double side) : base(side, side)
        {
        }
        public new Rectangle Resize(double newWidth, double newHeight)
        {
            if (newWidth == newHeight)
            {
                return new Square(newWidth);
            }
            else
            {
                return new Rectangle(newWidth, newHeight);
            }
        }
    }
}

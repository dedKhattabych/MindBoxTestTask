using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestTask.Shapes
{
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle Resize(double newWidth, double newHeight)
        {
            return new Rectangle(newWidth, newHeight);
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}

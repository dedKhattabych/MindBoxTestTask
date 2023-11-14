using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestTask.Shapes
{
    public class Triangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            double semiperimeter = (SideA + SideB + SideC) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
            return area;
        }

        // Прямоугольный ли треугольник
        public bool IsRightTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);

            double aSquared = sides[0] * sides[0];
            double bSquared = sides[1] * sides[1];
            double cSquared = sides[2] * sides[2];

            return aSquared + bSquared == cSquared;
        }
    }
}

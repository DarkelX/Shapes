using System.Linq;
using System.Reflection.Metadata;

namespace Shapes.Create
{
    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public bool IsRectangular => CheckRectangular();

        public Triangle(double SideA, double SideB, double SideC)
        {
            if (double.IsNegative(SideA) || double.IsNegative(SideB) || double.IsNegative(SideC))
                throw new Exception("Side can't be negative");

            if ((SideA + SideB < SideC)|| (SideA + SideC < SideB) || (SideC + SideB < SideA))
                throw new Exception("Impossible triangle");

            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }

        public double GetArea()
        {
            var semipPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(semipPerimeter * (semipPerimeter - SideA) * (semipPerimeter - SideB) * (semipPerimeter - SideC));
        }

        private double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        private bool CheckRectangular()
        {
            var sides = new List<double>() { SideA, SideB, SideC};

            var maxSideValue = sides.Max();
            sides.Remove(maxSideValue);

            return Math.Pow(maxSideValue, 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}

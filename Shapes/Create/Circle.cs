namespace Shapes.Create
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (double.IsNegative(radius))
                throw new Exception("Radius can't be negative");
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
namespace DesignPatterns.src.SOLID.I.BetterExample
{
    public class Circle : IShape2D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
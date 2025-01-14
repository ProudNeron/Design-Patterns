namespace DesignPatterns.src.SOLID.I.BadExample
{
    public class Ball : IShape
    {
        public double Radius {get; set;}
        public double Area()
        {
            throw new InvalidOperationException("Area not applicable for 3D shapes");
        }

        public double Volume()
        {
            return 4.0 * Math.PI * Radius * Radius * Radius / 3.0;
        }
    }
}
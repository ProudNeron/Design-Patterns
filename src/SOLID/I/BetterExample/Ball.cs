namespace DesignPatterns.src.SOLID.I.BetterExample
{
    public class Ball : IShape3D
    {
        public double Radius { get; set; }
        public double Volume()
        {
            return 4.0 * Math.PI * Radius * Radius * Radius / 3;
        }
    }
}
namespace DesignPatterns.src.SOLID.L.BadExample
{
    public class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Length { get; set; }
        public override double Area => Width * Length;
    }
}
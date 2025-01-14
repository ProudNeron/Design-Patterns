namespace DesignPatterns.src.SOLID.L.BadExample
{
    public class Square : Rectangle
    {
        public override double Width
        {
            get => base.Width;
            set => base.Width = base.Length = value;
        }
        public override double Length
        {
            get => base.Length;
            set => base.Length = base.Width = value;
        }
    }
}
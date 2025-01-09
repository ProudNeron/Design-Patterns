namespace DesignPatterns.src.OopPrinciples.Polymorphism
{
    public class Plane : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("The plane is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("The plane is stopping");
        }
    }
}
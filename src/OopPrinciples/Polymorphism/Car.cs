namespace DesignPatterns.src.OopPrinciples.Polymorphism
{
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("The car is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("The car is starting");
        }
    }
}
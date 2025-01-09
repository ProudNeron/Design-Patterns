namespace DesignPatterns.src.OopPrinciples.Polymorphism
{
    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("The motocycle is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("The motocycle is stopping");
        }    
    }
}
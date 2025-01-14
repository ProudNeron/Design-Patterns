namespace DesignPatterns.src.SOLID.D.BetterExample
{
    public class Car
    {
        private IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void StartCar()
        {
            _engine.Start();
            System.Console.WriteLine("Car started");
        }
    }
}
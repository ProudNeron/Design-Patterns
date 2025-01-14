namespace DesignPatterns.src.SOLID.D.BadExample
{
    public class Car
    {
        private Engine _engine;

        public Car()
        {
            _engine = new();
        }

        public void StartCar()
        {
            _engine.Start();
            System.Console.WriteLine("Car started.");
        }
    }
}
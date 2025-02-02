namespace DesignPatterns.src.DesignPatterns.Behavioural.Template.PolymorphismExample
{
    public class Camomile : IBeverage
    {
        public void Prepare()
        {
            Brew();
        }

        public void Brew()
        {
            System.Console.WriteLine("Brewing for 3 mins");
        }
    }
}
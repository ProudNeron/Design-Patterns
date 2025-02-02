namespace DesignPatterns.src.DesignPatterns.Behavioural.Template.PolymorphismExample
{
    public class BeverageMaker //strategy
    {
        private IBeverage _beverage;

        public BeverageMaker(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public void SetBeverage(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public void MakeBeverage()
        {
            // Common operations
            BoilWater();
            PourIntoCup();

            // Unique operations
            _beverage.Prepare();
        }

        private void BoilWater()
        {
            System.Console.WriteLine("Boiling water");
        }

        private void PourIntoCup()
        {
            System.Console.WriteLine("Pouring boiled water into cup");
        }

    }
}
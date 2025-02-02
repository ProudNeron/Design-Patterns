namespace DesignPatterns.src.DesignPatterns.Behavioural.Command.BadExample
{
    //Invoker
    public class RemoteControl
    {
        private readonly Light _light;

        public RemoteControl(Light light)
        {
            _light = light;
        }

        public void PressButton(bool turnOn)
        {
            if (turnOn)
            {
                _light.TurnOn();
            }
            else
            {
                _light.TurnOff();
            }
        }
        // Adding new functionality requires modifying this class
        public void DimLight()
        {
            _light.Dim();
        }
    }
}
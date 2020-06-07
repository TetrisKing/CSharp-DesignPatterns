namespace CSharp_DesignPatterns.Factory.AbstractFactory
{
    internal class CarBMW : ICar
    {
        public string TurnOff()
        {
            return "BMW shuts down";
        }

        public string TurnOn()
        {
            return "BMW powers up!";
        }
    }
}
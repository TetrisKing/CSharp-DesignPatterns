namespace CSharp_DesignPatterns.Factory.AbstractFactory
{
    internal class CarMiniCooper : ICar
    {
        public string TurnOff()
        {
            return "MiniCooper shuts down";
        }

        public string TurnOn()
        {
            return "MiniCooper powers up!";
        }
    }
}
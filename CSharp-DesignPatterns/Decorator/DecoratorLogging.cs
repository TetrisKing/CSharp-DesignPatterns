using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Decorator
{
    public class DecoratorLogging : IComponent
    {
        private readonly IComponent component;

        public DecoratorLogging(IComponent component)
        {
            this.component = component;
        }

        public string GetEquipment()
        {
            Console.WriteLine("DecoratorLogging - GetEquipment called");
            return component.GetEquipment();
        }
    }
}

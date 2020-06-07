using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Decorator
{
    public class DecoratorEquipShield : IComponent
    {
        private readonly IComponent component;

        public DecoratorEquipShield(IComponent component)
        {
            this.component = component;
        }

        public string GetEquipment()
        {
            return component.GetEquipment() + " - SHIELD";
        }
    }
}

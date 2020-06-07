using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Decorator
{
    public class Component : IComponent
    {
        public string GetEquipment()
        {
            return "SWORD";
        }
    }
}

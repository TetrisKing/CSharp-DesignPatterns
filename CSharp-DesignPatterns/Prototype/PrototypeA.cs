using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Prototype
{
    public class PrototypeA : IPrototype
    {
        private readonly string name;

        public PrototypeA(string name)
        {
            this.name = name;
        }
        public IPrototype Clone()
        {
            PrototypeA newP = new PrototypeA(name);
            return newP;
        }

        public string GetName()
        {
            return name;
        }
    }
}

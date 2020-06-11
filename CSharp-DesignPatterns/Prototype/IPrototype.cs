using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Prototype
{
    public interface IPrototype
    {
        IPrototype Clone();
        string GetName();
    }
}

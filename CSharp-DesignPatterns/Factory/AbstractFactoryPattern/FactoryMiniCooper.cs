using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Factory.AbstractFactory
{
    public class FactoryMiniCooper: ICarFactory
    {
        public ICar CreateInstance()
        {
            return new CarMiniCooper();
        }
    }
}

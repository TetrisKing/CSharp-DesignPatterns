using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Factory
{
    public interface ICarFactory
    {
        public ICar CreateInstance(); 
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Factory
{
    public interface IFactory
    {
        public IShape CreateInstance(string shapeName, int sideLength); 
    }
}

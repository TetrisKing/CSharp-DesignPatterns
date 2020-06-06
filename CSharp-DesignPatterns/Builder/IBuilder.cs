using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Builder
{
    public interface IBuilder
    {
        void BuildId();
        void BuildName();
        Product GetProduct();
        void Reset();
    }
}

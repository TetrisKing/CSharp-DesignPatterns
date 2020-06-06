using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Builder
{
    public class Director
    {
        private readonly IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public Product BuildFull()
        {
            Console.WriteLine($"\n{builder.GetType().Name} - BuildFull");
            builder.BuildId();
            builder.BuildName();
            return builder.GetProduct();
        }
        public Product BuildNameOnly()
        {
            Console.WriteLine($"\n{builder.GetType().Name} - BuildNameOnly");
            builder.BuildName();
            return builder.GetProduct();
        }
    }
}

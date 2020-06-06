using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Builder
{
    public class ConcreteBuilderLowerCase : IBuilder
    {
        private Product product;
        public ConcreteBuilderLowerCase()
        {
            Reset();
        }

        public void Reset() {
            product = new Product();
        }

        public void BuildId()
        {
            product.Id = 1;
        }

        public void BuildName()
        {
            product.Name = "product_lowercase_name";
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}

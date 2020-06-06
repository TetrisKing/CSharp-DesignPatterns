using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Builder
{
    public class ConcreteBuilderUpperCase : IBuilder
    {
        private Product product;
        public ConcreteBuilderUpperCase()
        {
            Reset();
        }

        public void Reset() {
            product = new Product();
        }

        public void BuildId()
        {
            product.Id = 9000;
        }

        public void BuildName()
        {
            product.Name = "PRODUCT_UPPERCASE_NAME";
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}

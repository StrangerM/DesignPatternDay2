using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Product
    {
        private List<object> product;
        public Product()
        {
            product = new List<object>();
        }

        public void Add(object item)
        {
            product.Add(item);
        }

        public void Show()
        {
            foreach (var item in product)
            {
                Console.WriteLine( item );
            }
        }
    }
}

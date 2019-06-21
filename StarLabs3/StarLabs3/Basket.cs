using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

namespace StarLabs3
{
    public class Basket
    {

        List<Product> products = new List<Product>();

        private List<Product> Items;

        public Basket()
        {
            Items = new List<Product>();
        }
        

        public void AddProduct(Product product)
        {
            this.products.Add(product);

            
        }

        public void RemoveProduct(Product product)
        {
            this.products.Remove(product);
        }

        public double CalculateTotal()
        {
            double total = 0;
          
            foreach (Product product in this.products)
            {
                total = (total + product.GetPrice());
            }

            return total;
        }
    }
}
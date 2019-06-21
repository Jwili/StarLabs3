using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs3
{
    public abstract class Product
    {

        public string Name { get; set; }
        public string Size { get; set; }
        public int SizePrice { get; set; }
        public int NoOfItems { get; set; }
        public double calculateTotal;

        public Product(string name, string size)
        {
            name = this.Name;
            size = this.Size;


            Name = name;
            Size = size;    

        }

        public string GetName()
        {
            return this.Name;
        }
       
        public void SetName(string name)
        {
        name = this.Name;
        }
        public double GetTotal()
        {
            return this.calculateTotal;
        }
        public string GetSize()
        {
            return this.Size;
        }

        public void SetSize(string size)
        {
            size = this.Size;
        }

        public abstract double GetPrice();

        public int GetDefaultPrice()
        {
            if (this.GetSize()=="S")
            {
                return 10;
            }
            else if (this.GetSize()=="M")
            {
                return 20;
            }

            return 30;
        }
        public virtual void TshirtPrices()
        {
            Console.WriteLine("*******Add To Your Shopping basket*******");
            Console.WriteLine("------------Tshirt-----------------");
            Console.WriteLine("1. Small  : R10");
            Console.WriteLine("2. Medium : R20");
            Console.WriteLine("3. Large  : R30");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("------------Golf-T-----------------");
            Console.WriteLine("4. Small  : R20");
            Console.WriteLine("5. Medium : R40");
            Console.WriteLine("6. Large  : R60");
            Console.WriteLine("-----------------------------------");
        }
        public virtual void PantstPrices()
        {
            Console.WriteLine("*******Add Pansts To Your Shopping basket*******");
            Console.WriteLine("------------ Jeans -----------------");
            Console.WriteLine("1. Small  : R10");
            Console.WriteLine("2. Medium : R20");
            Console.WriteLine("3. Large  : R30");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("------------- FormalPants-----------------");
            Console.WriteLine("4. Small  : R40");
            Console.WriteLine("5. Medium : R50");
            Console.WriteLine("6. Large  : R60");
            Console.WriteLine("-----------------------------------");
        }
    }
}
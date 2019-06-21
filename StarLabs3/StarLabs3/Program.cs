using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs3
{
    public class Program
    {
        public static void Main(String[] args)
        {
            
            {
                Basket basket = new Basket();
                TShirt tshirt1 = new TShirt("whiteTshirt", "S");
                TShirt tshirt2 = new TShirt("blueTshirt", "L");
                Golfer golfer1 = new Golfer("golfer", "M");
                Jeans jean1 = new Jeans("jean", "M");
                FormalPants pants1 = new FormalPants("pants1", "L");

                //System.Console.WriteLine("Enter size of Tshirt");
                //var tshirtSize = Console.ReadLine();

                basket.AddProduct(tshirt1);
                basket.AddProduct(tshirt2);
                basket.AddProduct(golfer1);
                basket.AddProduct(jean1);
                basket.AddProduct(pants1);
              
                Console.WriteLine("***********************************************");

                System.Console.WriteLine($"Your total price is :R {basket.CalculateTotal()}");
                Console.WriteLine("***********************************************");
                Console.Read();
            }
        }
    }
}

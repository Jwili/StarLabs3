using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs3
{

    public class TShirt : Product
    {


        public TShirt(string name, string size) : base(name, size)
        {
            //base.GetName();
            //base.GetSize();
            name = this.GetName();
            size = this.GetSize();

            TshirtPrices();
            Console.Write("Type (S)-For Small, (M)-Medium, (L)-Larg : ");
            Console.Write("Enter The Shirt Size You Want : ");
            Size = Console.ReadLine();

            Console.Write("Enter Number Of Items You Want: ");
            NoOfItems = int.Parse(Console.ReadLine());
            switch (Size)

            {
                case "S":
                    SizePrice = 10;
                    Console.WriteLine("You Selected Small : With The Price Of R10");
                    break;

                case "M":
                    SizePrice = 20;
                    Console.WriteLine("You have Selected Medium : : With The Price Of R20");
                    break;
                case "L":
                    SizePrice = 30;
                    Console.WriteLine("You have Selected Large : : With The Price Of R30");
                    break;
            }

   

        }



        public override double GetPrice()
        {
            return this.GetDefaultPrice();
        }
    }
}
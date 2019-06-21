using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs3
{
    public class FormalPants : Product
    {

        public FormalPants(string name, string size) : base(name, size)
        {
            base.GetName();
            base.GetSize();
            Console.Write("Enter The Formal Pants Size You Want : ");
            Size = Console.ReadLine();

            Console.Write("Enter Number Of Items You Want: ");
            NoOfItems = int.Parse(Console.ReadLine());
            switch (Size)

            {
                case "S":
                    SizePrice = 40;
                    Console.WriteLine("You Selected Small : With The Price Of ", "R40");
                    break;

                case "M":
                    SizePrice = 40;
                    Console.WriteLine("You have Selected Medium : : With The Price Of ", "R50");
                    break;
                case "L":
                    SizePrice = 50;
                    Console.WriteLine("You have Selected Large : : With The Price Of ", "R60");
                    break;
            }
        }

        public override double GetPrice()
        {
            return (this.GetDefaultPrice() + 30);
        }

        //public override string ToString()
        //{
        //    return string.Format("GetDefaultPrice() + 30");
        //}

    }
}

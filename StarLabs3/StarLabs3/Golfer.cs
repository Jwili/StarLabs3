using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs3
{
    public class Golfer : Product
    {
        //private string name;
        //private string size;


        public Golfer(string name, string size) :
                base(name, size)
        {
 
            //  base.(name, size);
            base.GetName();
            base.GetSize();
            Console.Write("Enter The Golfer Size You Want : ");
            Size = Console.ReadLine();
            Console.Write("Enter Number Of Golfers You Want: ");
            NoOfItems = int.Parse(Console.ReadLine());

        }

        public override double GetPrice()
        {
            return (this.GetDefaultPrice() * 2);
        }
    }
}

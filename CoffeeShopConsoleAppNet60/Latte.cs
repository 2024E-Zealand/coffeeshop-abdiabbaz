using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public Latte():this(0,"")
        {
        }

        public Latte(int discount, string blend) : base(discount, blend)
        {
        }

        public int mlMilk()
        {
            return 200;
        }

        public override int Price()
        {
            if (Discount > 5)
            {
                throw new ArgumentOutOfRangeException();
            }
            return 40 - Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}

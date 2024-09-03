using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado():this(0,"")
        {
        }

        public Cortado(int discount, string blend) : base(discount, blend)
        {
        }

        public int mlMilk()
        {
            return 40;   
        }

        public override int Price()
        {
            if (Discount > 5)
            {
                throw new ArgumentOutOfRangeException();
            }
            return 25 - Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}

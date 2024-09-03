using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class FlatWhite : Coffee
    {
        public FlatWhite():this(0,"")
        {
            
        }

        public FlatWhite(int discount, string blend) : base(discount, blend)
        {
        }

        public override string Strength()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {

        private int _discount;

        private string _blend;

        public string Blend
        {
            get { return _blend; }
            set { _blend = value; }
        }


        public int Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        protected Coffee():this(0,"")
        {
            
        }

        protected Coffee(int discount, string blend)
        {
            Discount = discount;
            Blend = blend;
        }

        public virtual int Price()
        {
            if(Discount > 5)
            {
                throw new ArgumentOutOfRangeException();
            }
            return 20 - Discount;
        }

        public abstract string Strength();


	}
}

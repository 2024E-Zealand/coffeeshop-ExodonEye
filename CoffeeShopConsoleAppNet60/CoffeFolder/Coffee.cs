using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60.AddOns;

namespace CoffeeShopConsoleAppNet60.CoffeFolder
{
    public abstract class Coffee
    {
        private int _discount;

        public Coffee(int Discount = 0) 
        {
            Discount = _discount;
        }
        public int Discount 
        { 
            get { return _discount; } 
            set 
            {
                if (value < 5)
                {
                    throw new ArgumentException("max five kr. in discount");
                }
                _discount = value;
            }
        }

        public virtual int Price()
        {
            return 20;
        }

        public abstract StrengthCoffee Strength();

        public abstract Temp Temperatur();

    }
}

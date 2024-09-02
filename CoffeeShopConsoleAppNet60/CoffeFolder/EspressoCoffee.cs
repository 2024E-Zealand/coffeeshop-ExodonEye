using CoffeeShopConsoleAppNet60.AddOns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.CoffeFolder
{
    public class EspressoCoffee : Coffee
    {
        public override int Price()
        {
            return 35 - Discount;
        }

        public override StrengthCoffee Strength()
        {
            return StrengthCoffee.Strong;
        }

        public override Temp Temperatur()
        {
            return Temp.Hot;
        }
    }
}

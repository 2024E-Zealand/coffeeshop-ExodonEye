using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60.AddOns;
using CoffeeShopConsoleAppNet60.AddOns.Interfaces;

namespace CoffeeShopConsoleAppNet60.CoffeFolder
{
    public class CortadoCoffee : Coffee, IMilk
    {
        public override int Price()
        {
            return 25 - Discount;
        }

        public override StrengthCoffee Strength()
        {
            return StrengthCoffee.Medium;
        }

        public int mlMilk()
        {
            return 40;
        }

        public override Temp Temperatur()
        {
            return Temp.Hot;
        }
    }
}

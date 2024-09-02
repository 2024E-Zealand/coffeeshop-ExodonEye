using CoffeeShopConsoleAppNet60.AddOns;
using CoffeeShopConsoleAppNet60.AddOns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.CoffeFolder
{
    public class IceCoffee : Coffee, IMilk
    {
        public override int Price()
        {
            return 45 - Discount;
        }

        public override StrengthCoffee Strength()
        {
            return StrengthCoffee.Medium;
        }

        public int mlMilk()
        {
            return 50;
        }

        public override Temp Temperatur()
        {
            return Temp.Cold;
        }
    }
}

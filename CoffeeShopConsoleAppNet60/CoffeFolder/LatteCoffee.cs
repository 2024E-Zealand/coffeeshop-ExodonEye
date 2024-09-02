using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60.AddOns;
using CoffeeShopConsoleAppNet60.AddOns.Interfaces;

namespace CoffeeShopConsoleAppNet60.CoffeFolder
{
    public class LatteCoffee : Coffee, IMilk
    {
        public override int Price()
        {
            return 40 - Discount;
        }

        public override StrengthCoffee Strength()
        {
            return StrengthCoffee.Weak;
        }

        public int mlMilk()
        {
            return 200;
        }

        public override Temp Temperatur()
        {
            return Temp.Hot;
        }

    }
}

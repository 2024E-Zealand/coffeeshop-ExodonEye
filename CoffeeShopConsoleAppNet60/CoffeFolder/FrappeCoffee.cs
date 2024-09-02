using CoffeeShopConsoleAppNet60.AddOns;
using CoffeeShopConsoleAppNet60.AddOns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.CoffeFolder
{
    public class FrappeCoffee : Coffee, IMilk
    {
        public override int Price()
        {
            return 55 - Discount;
        }

        public override StrengthCoffee Strength()
        {
            return StrengthCoffee.Weak;
        }

        public int mlMilk()
        {
            return 250;
        }

        public override Temp Temperatur()
        {
            return Temp.Lukewarm;
        }
    }
}

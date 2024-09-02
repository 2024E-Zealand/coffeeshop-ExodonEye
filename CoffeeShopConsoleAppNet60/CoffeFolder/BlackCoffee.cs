using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60.AddOns;

namespace CoffeeShopConsoleAppNet60.CoffeFolder
{
    public class BlackCoffee : Coffee
    {
        public override int Price()
        {
            return base.Price() - Discount;
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

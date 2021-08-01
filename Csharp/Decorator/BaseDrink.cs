using System;

namespace Decorator
{
    public class Espressio : Beverage
    {
        public Espressio() {
            description = "Espresso";
        }

        public override decimal cost() {
            return 1.99m;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend() {
            description = "House Blend";
        }

        public override decimal cost() {
            return 0.89m;
        }
    }

    public class Decaf : Beverage
    {
        public Decaf() {
            description = "Decaf";
        }

        public override decimal cost() {
            return 1.05m;
        }
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast() {
            this.description = "Dark Roast";
        }

        public override decimal cost() {
            return 0.99m;
        }
    }
}
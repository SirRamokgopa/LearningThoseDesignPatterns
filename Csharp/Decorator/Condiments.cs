using System;

namespace Decorator
{
    public class Mocha : CondimentDecorator
    {
        Beverage baseBeverage;
        decimal thisCost = 0.20m;

        public Mocha(Beverage beverage) {
            baseBeverage = beverage;
        }

        public override string getDescription() {
            return $"{baseBeverage.getDescription()}\n+  Mocha";
        }

        public override decimal cost() {
            return thisCost + baseBeverage.cost();
        }
    }

    public class Whip : CondimentDecorator
    {
        Beverage baseBeverage;
        decimal thisCost = 0.10m;

        public Whip(Beverage beverage) {
            baseBeverage = beverage;
        }

        public override string getDescription() {
            return $"{baseBeverage.getDescription()}\n+  Whip";
        }

        public override decimal cost() {
            return thisCost + baseBeverage.cost();
        }
    }

    public class SteamMilk : CondimentDecorator
    {
        Beverage baseBeverage;
        decimal thisCost = 0.10m;

        public SteamMilk(Beverage beverage) {
            baseBeverage = beverage;
        }

        public override string getDescription() {
            return $"{baseBeverage.getDescription()}\n+  Steamed Milk";
        }

        public override decimal cost() {
            return thisCost + baseBeverage.cost();
        }
    }

    public class Soy : CondimentDecorator
    {
        Beverage baseBeverage;
        decimal thisCost = 0.15m;

        public Soy(Beverage beverage) {
            baseBeverage = beverage;
        }

        public override string getDescription() {
            return $"{baseBeverage.getDescription()}\n+  Soy";
        }

        public override decimal cost() {
            return thisCost + baseBeverage.cost();
        }

    }
}
/*
 * This Pizza store is the factory class
 * The PizzaStore class handles the creation of all pizza objects
 * The concrete pizza stores are the instantiations of this factory class
 */
using System;

namespace Factory
{
    public abstract class PizzaStore {
        public Pizza orderPizza(string type) {
            Pizza pizza;

            pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        protected abstract Pizza createPizza(string type);
    }
}
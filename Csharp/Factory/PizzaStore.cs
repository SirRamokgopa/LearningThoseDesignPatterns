/*
 * This Pizza store is the factory class
 * The PizzaStore class handles the creation of all pizza objects
 * The concrete pizza stores are the instantiations of this factory class
 */
using System;
/*
 * This is the abstract interface for PizzaStore-s
 * PizzaStore is the factory that makes Pizza
 */
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
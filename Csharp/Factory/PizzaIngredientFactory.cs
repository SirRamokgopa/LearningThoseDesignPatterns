/*
 * This is the interface for the IngredientFactory-s
 * It's subclasses will be fatories that creates the ingredients
 * for a Pizza
 * (This makes the Abstract Factory Pattern)
 */
using System;
using Ingredients;

namespace Factory
{
    public interface PizzaIngredientFactory 
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public Veggies[] createVeggies();
        public Pepperoni createPepperoni();
        public Clams createClams();
    }
}
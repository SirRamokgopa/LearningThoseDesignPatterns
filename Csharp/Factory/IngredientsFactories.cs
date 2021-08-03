using System;
using Ingredients;

namespace Factory
{
    public class NYIngredientFactory : PizzaIngredientFactory
    {
        public NYIngredientFactory() {}
        
        public Dough createDough() {
            return new ThinCrustDough();
        }
        public Sauce createSauce() {
            return new MarinaraSauce();
        }
        public Cheese createCheese() {
            return new RegiannoCheese();
        }
        public Veggies[] createVeggies() {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
        public Pepperoni createPepperoni() {
            return new SlicedPepperoni();
        }
        public Clams createClams() {
            return new FreshClams();
        }
    }

    public class ChicagoIngredientFactory : PizzaIngredientFactory
    {
        public Dough createDough() {
            return new ThickCrustDough();
        }
        public Sauce createSauce() {
            return new PlumTomatoSauce();
        }
        public Cheese createCheese() {
            return new MozzarellaCheese();
        }
        public Veggies[] createVeggies() {
            Veggies[] veggies = { new Spinach(), new BlackOlives(), new EggPlant() };
            return veggies;
        }
        public Pepperoni createPepperoni() {
            return new SlicedPepperoni();
        }
        public Clams createClams() {
            return new FrozenClams();
        }
    }

    public class CaliIngredientsFactory : PizzaIngredientFactory
    {
        public Dough createDough() {
            return new ThickCrustDough();
        }
        public Sauce createSauce() {
            return new PlumTomatoSauce();
        }
        public Cheese createCheese() {
            return new MozzarellaCheese();
        }
        public Veggies[] createVeggies() {
            Veggies[] veggies = { new Spinach(), new BlackOlives(), new EggPlant() };
            return veggies;
        }
        public Pepperoni createPepperoni() {
            return new SlicedPepperoni();
        }
        public Clams createClams() {
            return new FrozenClams();
        }
    }
}
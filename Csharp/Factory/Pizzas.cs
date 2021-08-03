/*
 * These are the conctrete Pizza classes 
 */
using System;

namespace Factory
{
    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine($"Preparing {name}");
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }

    public class PepperoniPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine($"Preparing {name}");
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            pepperoni = ingredientFactory.createPepperoni();
        }
    }

    public class ClamPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine($"Preparing {name}");
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            clam = ingredientFactory.createClams();
        }
    }

    public class veggiePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public veggiePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine($"Preparing {name}");
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            clam = ingredientFactory.createClams();
        }
    }
}
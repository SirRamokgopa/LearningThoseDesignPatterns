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
    
    // public class ChicagoStyleCheesePizza : Pizza
    // {
    //     public ChicagoStyleCheesePizza()
    //     {
    //         name = "Chicago Style Deep Dish Cheese Pizza";
    //         dough = "Extra Thick Crust Dough";
    //         sauce = "Plum Tomato Sauce";
    //         toppings.Add("Shredded Mozzarella Cheese");
    //     }
    //     public override void cut()
    //     {
    //         Console.WriteLine("Cutting the pizza into square slices");
    //     }
    // }

    // public class NYStyleCheesePizza : Pizza
    // {
    //     public NYStyleCheesePizza()
    //     {
    //         name = "NY Style Sauce and Cheese Pizza";
    //         dough = "Thin Crust Dough";
    //         sauce = "Mariana Sauce";
    //         toppings.Add("Grated Reggiano Cheese");
    //     }
    // }

    // public class CaliStyleCheesePizza : Pizza
    // {
    //     public CaliStyleCheesePizza()
    //     {
    //         name = "California Style Sauce and Cheese Pizza";
    //         dough = "Thin Crust Dough";
    //         sauce = "Mariana Sauce";
    //         toppings.Add("Sliced Mozzerella Cheese");
    //     }

    //     public override void bake()
    //     {
    //         Console.WriteLine("Baking in fire oven");
    //     }
    // }

    // public class NYStylePepperoniPizza : Pizza
    // {
    //     public NYStylePepperoniPizza()
    //     {
    //         name = "NY Style Pepperoni Pizza";
    //         dough = "Thin Crust Dough";
    //         sauce = "Mariana Sauce";
    //         toppings.Add("Grated Reggiano Cheese");
    //         toppings.Add("Pepperoni slices");
    //     }
    // }

    // public class CaliStylePepperoniPizza : Pizza
    // {
    //     public CaliStylePepperoniPizza()
    //     {
    //         name = "California Style Pepperoni Pizza";
    //         dough = "Thin Crust Dough";
    //         sauce = "Mariana Sauce";
    //         toppings.Add("Sliced mozzerella Cheese");
    //         toppings.Add("Pepperoni slices");
    //     }

    //     public override void bake()
    //     {
    //         Console.WriteLine("Baking in fire oven");
    //     }
    // }

    
}
using System;

namespace Factory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(String item) {
            Pizza pizza = null;
            PizzaIngredientFactory NYIngredientsFactory = new NYIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(NYIngredientsFactory);
                pizza.name = "NY Style Sauce and Cheese Pizza";
            }
            else if (item.Equals("veggie"))
            {
                pizza = new veggiePizza(NYIngredientsFactory);
                pizza.name = "NY Style Veggie Pizza";
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(NYIngredientsFactory);
                pizza.name = "NY Style Clam Pizza";
            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(NYIngredientsFactory);
                pizza.name = "NY Style Pepperoni Pizza";
            }
            return null;
        }
    }

    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(String item) {
            Pizza pizza = null;
            PizzaIngredientFactory ChicagoIngredientsFactory = new ChicagoIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ChicagoIngredientsFactory);
                pizza.name = "Chicago Style Sauce and Cheese Pizza";
            }
            else if (item.Equals("veggie"))
            {
                pizza = new veggiePizza(ChicagoIngredientsFactory);
                pizza.name = "Chicago Style Veggie Pizza";
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ChicagoIngredientsFactory);
                pizza.name = "Chicago Style Clam Pizza";
            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ChicagoIngredientsFactory);
                pizza.name = "Chicago Style Pepperoni Pizza";
            }
            return null;
        }
    }

    public class CaliPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(String item) {
            Pizza pizza = null;
            PizzaIngredientFactory caliIngredientsFactory = new CaliIngredientsFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(caliIngredientsFactory);
                pizza.name = "Chicago Style Sauce and Cheese Pizza";
            }
            else if (item.Equals("veggie"))
            {
                pizza = new veggiePizza(caliIngredientsFactory);
                pizza.name = "Chicago Style Veggie Pizza";
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(caliIngredientsFactory);
                pizza.name = "Chicago Style Clam Pizza";
            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(caliIngredientsFactory);
                pizza.name = "Chicago Style Pepperoni Pizza";
            }
            return null;
        }
    }
}
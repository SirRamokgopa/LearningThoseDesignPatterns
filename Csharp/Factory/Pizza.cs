/*
 * This Pizza is the abstract class that all Pizzas will be made from
 * The PizzaStore class handles the creation of all pizza objects
 * The concrete pizza are the instantiations of this abstract class
 */
using System;
using System.Collections;
using Ingredients;

namespace Factory
{
    public abstract class Pizza {
        private string _name;
        public Dough dough;
        public Sauce sauce;
        public Cheese cheese;
        public Veggies[] veggies;
        public Pepperoni pepperoni;
        public Clams clam;

        public abstract void prepare();

        public virtual void bake() {
            Console.WriteLine("Bake at 200degC for 25 minutes");
        }

        public virtual void cut() {
            Console.WriteLine("Cutting into diagonal slices");
        }

        public void box() {
            Console.WriteLine("Place Pizza in official PizzaStore box");
        }

        // I just found this cool way to do getters and setters check out Using Properties in the docs
        public string name {
            get => _name;
            set => _name = value;
        }
    }
}
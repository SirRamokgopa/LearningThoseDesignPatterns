using System;

namespace Ingredients
{
    public interface Cheese
    {
        public string name { get; }
    }

    public class MozzarellaCheese : Cheese
    {
        private string _name;
        public MozzarellaCheese() 
        {
            _name = "Grated Mozzerella Cheese";
        }

        public string name {
            get => _name;
        }
    }

    public class RegiannoCheese : Cheese
    {
        private string _name;
        public RegiannoCheese() 
        {
            _name = "Shredded Reggiano Cheese";
        }

        public string name {
            get => _name;
        }
    }
}
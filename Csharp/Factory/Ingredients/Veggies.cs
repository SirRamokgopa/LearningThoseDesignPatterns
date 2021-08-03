using System;

namespace Ingredients
{
    public interface Veggies
    {
        public string name { get; }
    }

    public class Onion : Veggies
    {
        private string _name;
        public Onion() 
        {
            _name = "Onion";
        }

        public string name {
            get => _name;
        }
    }

    public class Spinach : Veggies
    {
        private string _name;
        public Spinach() 
        {
            _name = "Spinach";
        }

        public string name {
            get => _name;
        }
    }

    public class BlackOlives : Veggies
    {
        private string _name;
        public BlackOlives() 
        {
            _name = "Black Olives";
        }

        public string name {
            get => _name;
        }
    }

    public class EggPlant : Veggies
    {
        private string _name;
        public EggPlant() 
        {
            _name = "Eggplant";
        }

        public string name {
            get => _name;
        }
    }

    public class Garlic : Veggies
    {
        private string _name;
        public Garlic() 
        {
            _name = "Garlic";
        }

        public string name {
            get => _name;
        }
    }

    public class RedPepper : Veggies
    {
        private string _name;
        public RedPepper() 
        {
            _name = "Red Pepper";
        }

        public string name {
            get => _name;
        }
    }

    public class Mushroom : Veggies
    {
        private string _name;
        public Mushroom() 
        {
            _name = "Mushroom";
        }

        public string name {
            get => _name;
        }
    }
}
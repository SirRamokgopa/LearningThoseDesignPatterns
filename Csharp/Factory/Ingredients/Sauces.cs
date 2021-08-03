using System;

namespace Ingredients
{
    public interface Sauce
    {
        public string name { get; }
    }

    public class PlumTomatoSauce : Sauce
    {
        private string _name;
        public PlumTomatoSauce() 
        {
            _name = "Plum Tomato Sauce";
        }

        public string name {
            get => _name;
        }
    }

    public class MarinaraSauce : Sauce
    {
        private string _name;
        public MarinaraSauce() 
        {
            _name = "Marinara Sauce";
        }

        public string name {
            get => _name;
        }
    }
}
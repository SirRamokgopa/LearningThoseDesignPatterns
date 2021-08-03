using System;

namespace Ingredients
{
    public interface Pepperoni
    {
        public string name { get; }
    }

    public class SlicedPepperoni : Pepperoni
    {
        private string _name;
        public SlicedPepperoni() 
        {
            _name = "Sliced Pepperoni";
        }

        public string name {
            get => _name;
        }
    }
}
using System;

namespace Ingredients
{
    public interface Dough
    {
        public string name { get; }
    }

    public class ThickCrustDough : Dough
    {
        private string _name;
        public ThickCrustDough() 
        {
            _name = "Thick Crust Dough";
        }

        public string name {
            get => _name;
        }
    }

    public class ThinCrustDough : Dough
    {
        private string _name;
        public ThinCrustDough() 
        {
            _name = "Thin Crust Dough";
        }

        public string name {
            get => _name;
        }
    }
}
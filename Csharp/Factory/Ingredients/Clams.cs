using System;

namespace Ingredients
{
    public interface Clams
    {
        public string name { get; }
    }

    public class FrozenClams : Clams
    {
        private string _name;
        public FrozenClams() 
        {
            _name = "Frozen Clams";
        }

        public string name {
            get => _name;
        }
    }

    public class FreshClams : Clams
    {
        private string _name;
        public FreshClams() 
        {
            _name = "Fresh Clam";
        }

        public string name {
            get => _name;
        }
    }
}
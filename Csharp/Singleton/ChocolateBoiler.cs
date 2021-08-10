using System;

namespace Singleton
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        // Variable to hold only instance of chocolate boiler
        private static ChocolateBoiler chocolateBoiler;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetBoiler()
        {
            if (chocolateBoiler == null)
            {
                chocolateBoiler = new ChocolateBoiler();
            }
            return chocolateBoiler;
        }

        public void fill()
        {
            if (isEmpty())
            {
                empty = false;
                boiled = false;
                // fi ll the boiler with a milk/chocolate mixture
            }
        }
        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                // drain the boiled milk and chocolate
                empty = true;
            }
        }
        public void boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                // bring the contents to a boil
                boiled = true;
            }
        }

        public bool isEmpty()
        {
            return empty;
        }
        public bool isBoiled()
        {
            return boiled;
        }
    }
}
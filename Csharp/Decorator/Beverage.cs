/* This is the main beverage class
 * We will extend it's functionality by using the decorator pattern
 * Because we favor composition over inheritence
*/
namespace Decorator
{
    public abstract class Beverage
    {
        protected string  description = "Unknown beverage";

        public virtual string getDescription() {
            return description;
        }

        public abstract decimal cost();
    }
}
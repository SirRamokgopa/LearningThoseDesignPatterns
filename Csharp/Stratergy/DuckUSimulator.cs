/*
 * This is the Strategy Pattern which defines a family of algorithms, 
 * encapsulates each one, and makes them interchangeable. 
 * Strategy lets the algorithm vary independently from 
 * clients that use it.
 * 
 * So, you can create ducks that can do different things because their
 * behaviour is encapsulated.
 */
 
 using System;

namespace Stratergy
{
    public class MiniDuckSim
    {
        public static void mainForDuckSim(String[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
        
            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehaviour(new FlyRocketPowered());
            model.performFly();
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
        }
        public override void display() {
                Console.WriteLine("I am a mallard boi.");
            }
    }
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            quackBehaviour = new MuteQuack();
            flyBehaviour = new FlyNoWay();
        }
        public override void display() {
                Console.WriteLine("I am a model duck.");
            }
    }
}
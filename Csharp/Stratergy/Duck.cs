using System;

namespace Stratergy
{
    public abstract class Duck
    {
        // Instance vars for behavior interfaces
        public FlyBehaviour flyBehaviour;
        public QuackBehaviour quackBehaviour;

        public abstract void display();
        
        public void performFly() 
        {
            flyBehaviour.fly();
        }

        public void performQuack() 
        {
            quackBehaviour.quack();
        }

        public void setFlyBehaviour(FlyBehaviour behaviour) 
        {
            flyBehaviour = behaviour;
        }
        
        public void setQuackyBehaviour(QuackBehaviour behaviour) 
        {
            quackBehaviour = behaviour;
        }

        public void swim()
        {
            Console.WriteLine("All quacks can fly! Even the facke ones. :P");
        }
    }
}
using System;

namespace Stratergy
{
    public class MuteQuack : QuackBehaviour
    {
        public void quack() 
        {
            Console.WriteLine("   ...**silence");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Duck_Strategy_Pattern_Example
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings!");
        }
    }

    class FlyWithRocket : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with rocket!");
        }
    }

    class CantFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Can't fly!");
        }
    }

    class QuackAble : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack, quack!");
        }
    }

    class Squeez : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squee, squee!");
        }
    }

    class CantQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("!");
        }
    }

}

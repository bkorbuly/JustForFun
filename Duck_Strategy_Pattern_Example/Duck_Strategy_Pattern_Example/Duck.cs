using System;
using System.Collections.Generic;
using System.Text;

namespace Duck_Strategy_Pattern_Example
{
    public abstract class Duck
    {
        IFlyBehavior flyer;
        IQuackBehavior quacker;

        public virtual void Fly()
        {
            this.flyer.Fly();
        }

        public virtual void SetFly(IFlyBehavior newFlyer)
        {
            this.flyer = newFlyer;
        }

        public virtual void Quack()
        {
            this.quacker.Quack();
        } 

        public virtual void SetQuack(IQuackBehavior newQuacker)
        {
            this.quacker = newQuacker;
        }

        public virtual void Swim()
        {
            Console.WriteLine("Swish, swish!");
        }
    }
}

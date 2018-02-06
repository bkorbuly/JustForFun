using System;
using System.Collections.Generic;
using System.Text;

namespace Duck_Strategy_Pattern_Example
{
    public abstract class Duck
    {
        protected IFlyBehavior Flyer { get; set; }
        protected IQuackBehavior Quacker { get; set; }

        public virtual void Fly()
        {
            this.Flyer.Fly();
        }

        public virtual void Quack()
        {
            this.Quacker.Quack();
        } 

        public virtual void Swim()
        {
            Console.WriteLine("Swish, swish!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Duck_Strategy_Pattern_Example
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public interface IQuackBehavior
    {
        void Quack();
    }
}

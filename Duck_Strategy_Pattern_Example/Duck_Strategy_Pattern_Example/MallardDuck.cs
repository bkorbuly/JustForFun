using System;
using System.Collections.Generic;
using System.Text;

namespace Duck_Strategy_Pattern_Example
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetFly(new FlyWithWings());
            SetQuack(new QuackAble());
        }
    }
}

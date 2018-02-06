using System;
using System.Collections.Generic;
using System.Text;

namespace Duck_Strategy_Pattern_Example
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Flyer = new FlyWithWings();
            Quacker = new QuackAble();
        }
    }
}

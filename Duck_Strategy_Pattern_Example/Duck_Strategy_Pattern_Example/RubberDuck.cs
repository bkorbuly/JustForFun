using System;
using System.Collections.Generic;
using System.Text;

namespace Duck_Strategy_Pattern_Example
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            SetFly(new FlyWithRocket());
            SetQuack(new Squeez());
        }
    }
}

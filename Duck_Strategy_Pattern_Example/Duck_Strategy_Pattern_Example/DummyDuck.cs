using System;
using System.Collections.Generic;
using System.Text;

namespace Duck_Strategy_Pattern_Example
{
    public class DummyDuck : Duck
    {
        public DummyDuck()
        {
            SetFly(new CantFly());
            SetQuack(new CantQuack());
        }
    }
}

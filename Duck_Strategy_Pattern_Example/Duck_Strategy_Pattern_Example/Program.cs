using System;

namespace Duck_Strategy_Pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.Fly();
            mallardDuck.Quack();

            Console.WriteLine("");

            Duck dummyDuck = new DummyDuck();
            dummyDuck.Fly();
            dummyDuck.Quack();

            Console.WriteLine("");

            Duck rubberDuck = new RubberDuck();
            rubberDuck.Fly();
            rubberDuck.Quack();

            Console.ReadLine();
        }
    }
}

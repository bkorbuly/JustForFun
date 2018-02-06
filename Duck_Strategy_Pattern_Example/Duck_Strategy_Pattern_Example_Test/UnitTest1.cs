using Duck_Strategy_Pattern_Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;

namespace Duck_Strategy_Pattern_Example_Test
{
    [TestClass]
    public class UnitTest1
    {
        TextWriter currentConsoleOut = Console.Out;
        [TestMethod]
        public void TestMallardDuckFly()
        {            
            Duck duck = new MallardDuck();
            string text = "Fly with wings!\r\n";
            using (var consoleOutput = new ConsoleOutput())
            {
                duck.Fly();
                Assert.AreEqual(text, consoleOutput.GetOutput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);   
        }

        [TestMethod]
        public void TestRubberDuckFly()
        {
            Duck duck = new RubberDuck();
            string text = "Fly with rocket!\r\n";
            using (var consoleOutput = new ConsoleOutput())
            {
                duck.Fly();
                Assert.AreEqual(text, consoleOutput.GetOutput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void TestDummyDuckFly()
        {
            Duck duck = new DummyDuck();
            string text = "Can't fly!\r\n";
            using (var consoleOutput = new ConsoleOutput())
            {
                duck.Fly();
                Assert.AreEqual(text, consoleOutput.GetOutput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void TestMallardDuckQuack()
        {
            Duck duck = new MallardDuck();
            string text = "Quack, quack!\r\n";
            using (var consoleOutput = new ConsoleOutput())
            {
                duck.Quack();
                Assert.AreEqual(text, consoleOutput.GetOutput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void TestRubberDuckQuack()
        {
            Duck duck = new RubberDuck();
            string text = "Squee, squee!\r\n";
            using (var consoleOutput = new ConsoleOutput())
            {
                duck.Quack();
                Assert.AreEqual(text, consoleOutput.GetOutput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void TestDummyDuckQuack()
        {
            Duck duck = new DummyDuck();
            string text = "!\r\n";
            using (var consoleOutput = new ConsoleOutput())
            {
                duck.Quack();
                Assert.AreEqual(text, consoleOutput.GetOutput());
            }
            Assert.AreEqual(currentConsoleOut, Console.Out);
        }
    }
}

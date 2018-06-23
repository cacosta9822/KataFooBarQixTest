using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataFooBarQixTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumber9DivisibleBy3()
        {
            FooBarQix obj = new FooBarQix();
            var result= obj.compute("9");
            var expected = "Foo";


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber1DivisibleBy3()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("1");
            var expected = "1";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber25DivisibleBy5()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("25");
            var expected = "BarBar";

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestNumber28DivisibleBy7()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("28");
            var expected = "Qix";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber49DivisibleBy7()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("49");
            var expected = "Qix";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber3ContainsAndDivisibleBy3()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("3");
            var expected = "FooFoo";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber33ContainsAndDivisibleBy3()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("33");
            var expected = "FooFooFoo";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber5ContainsAndDivisibleBy5()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("5");
            var expected = "BarBar";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber55ContainsAndDivisibleBy5()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("55");
            var expected = "BarBarBar";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber7ContainsAndDivisibleBy7()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("7");
            var expected = "QixQix";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber77ContainsAndDivisibleBy7()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("77");
            var expected = "QixQixQix";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber357ContainsAndDivisible()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("357");
            var expected = "FooQixFooBarQix";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber101Contains0()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("101");
            var expected = "1*1";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber202Contains0()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("202");
            var expected = "2*2";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber303Contains0And3AndDivisibleBy3()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("303");
            var expected = "FooFoo*Foo";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNumber10101Contains0AndDivisibleBy5()
        {
            FooBarQix obj = new FooBarQix();
            var result = obj.compute("10101");
            var expected = "FooQix**";

            Assert.AreEqual(expected, result);
        }
    }
}
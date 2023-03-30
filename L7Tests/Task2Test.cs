using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using L7;

namespace L7Tests
{
    [TestClass]
    public class Task2Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task2 t = new Task2();
            double[] actual = t.t2(3.4, 5.5, 2.2);
            double[] expect = { -0.45, -3, 45 };
            Assert.AreEqual(actual[0], expect[0], 2);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using L7;

namespace L7Tests
{
    [TestClass]
    public class Task3Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task3 t = new Task3();
            bool actual = t.t3(1200);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Task3 t = new Task3();
            bool actual = t.t3(1300);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Task3 t = new Task3();
            Assert.ThrowsException<ArgumentException>(() => t.t3(0));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using L7;

namespace L7Tests
{
    [TestClass]
    public class Task1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task1 t = new Task1();
            string expected = "ABCD";
            string actual = t.t1(4);
            Assert.AreEqual(expected, actual);
        }
    }
}

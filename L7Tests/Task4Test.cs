using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using L7;

namespace L7Tests
{
    [TestClass]
    public class Task4Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task4 t = new Task4();
            bool actual = t.t4("test@test.ru");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using L7;

namespace L7Tests
{
    [TestClass]
    public class Task5Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task5 t = new Task5();
            int actual = t.t5("555555");
            int expected = 30;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            bool catched = false;
            Task5 t = new Task5();
            try
            {
                int value = Convert.ToInt32(t.t5("lol"));
            }
            catch (ArgumentException e)
            {
                catched = true;
            }
            Assert.IsTrue(catched, "Не обработаны недопустимые данные!");
        }
    }
}

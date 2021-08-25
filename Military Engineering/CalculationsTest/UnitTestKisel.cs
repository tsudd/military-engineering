using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculationsTest
{
    [TestClass]
    public class UnitTestKisel
    {
        [TestMethod]
        public void TestKisel()
        {
            Assert.AreEqual(CalculationsCore.Initial.Hello, "Hello Kisel");
        }
    }
}

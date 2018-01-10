using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ФАКТОРИАЛ;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 obj = new Class1();
            ulong f = obj.Factorial(1);
            Assert.AreEqual((ulong)1, f);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Class1 obj = new Class1();
            ulong f = obj.Factorial(5);
            Assert.AreEqual((ulong)120, f);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Class1 obj = new Class1();
            ulong f = obj.Factorial(18);
            Assert.AreEqual((ulong)6402373705728000, f);
        }
    }
}

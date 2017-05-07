using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using business;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string email = "test@gte.com";
            string sample = "590f69a3a1b9c";

            users u = new users();
            string output = u.apply(email);

            Assert.AreEqual(sample.Length, output.Length);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jenkins_01;

namespace JenkinsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.createMessage() == DateTime.Today.ToString("dd/MM/yyyy"));
        }
    }
}

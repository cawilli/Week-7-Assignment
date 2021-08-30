using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Week_7_Assignment;

namespace EssentialTrainingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testInstance = new Program();
            var testResult = testInstance.AddTwo(9, 5);
            Assert.AreEqual(14, testResult, "I expect 9 + 5 to be 14");
        }
    }
}

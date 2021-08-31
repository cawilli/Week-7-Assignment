using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Week_7_Assignment;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            
            testInstance.Sauces.Add("Chalula");
            testInstance.Sauces.Add("Sweet Chili");
            testInstance.Sauces.Add("Trailer Trash");

            //expect true 
            Assert.IsTrue(testInstance.IsSauceAwesome("Sweet Chili"));

            //expect false 
            Assert.IsFalse(testInstance.IsSauceAwesome("Red Hot"));

        }
    }
}

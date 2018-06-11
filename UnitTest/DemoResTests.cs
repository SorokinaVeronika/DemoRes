using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoRes;

namespace UnitTest
{
    [TestClass]
    public class DemoResTests
    {
        Functional functional;

        [TestInitialize]
        public void InitializeCurrentTest()
        {
            functional = new Functional();
        }

        [TestMethod]
        public void TestAddToRecipe()
        {
            string item = "banana";
            string expected = "banana";

           // functional.AddToRecipe();
        }
    }
}

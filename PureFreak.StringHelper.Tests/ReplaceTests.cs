using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PureFreak.StringHelper.Tests
{
    [TestClass]
    public class ReplaceTests
    {
        #region Test methods

        [TestMethod]
        public void ReplaceGlobalTest()
        {
            var myString = "This is a Test. This is a test. This is another Test.";
            myString = myString.ReplaceIgnoreCase("Test", "{Test}");

            Assert.AreEqual("This is a {Test}. This is a {Test}. This is another {Test}.", myString);
        }

        [TestMethod]
        public void ReplaceOneTest()
        {
            var myString = "This is a Test. This is a test. This is another Test.";
            myString = myString.ReplaceIgnoreCase("Test", "{Test}", false);

            Assert.AreEqual("This is a {Test}. This is a test. This is another Test.", myString);
        }

        [TestMethod]
        public void NullStringTest()
        {
            var myString = (string)null;
            myString = myString.ReplaceIgnoreCase("test", "123");

            Assert.AreEqual(null, myString);
        }

        #endregion
    }
}
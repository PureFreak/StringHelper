using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace PureFreak.StringHelper.Tests
{
    [TestClass]
    public class Md5Tests
    {
        [TestMethod]
        public void CreateTest()
        {
            var result = Md5.Create("Test äöü");
            Assert.AreEqual("2FDF469F718C0489A7AEC1509260D6CB", result);
        }

        [TestMethod]
        public void CreateWithCustomEncodingTest()
        {
            var result = Md5.Create("Test äöü", Encoding.ASCII);
            Assert.AreEqual("8D346EB72D54BAFFB3B27081C8B8E96E", result);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bob;

namespace Tests
{
    [TestClass]
    public class GeneratorTests
    {
        [TestMethod]
        public void CanGenerateWordOfSetLength()
        {
            var generator = new Generator();
            var name = generator.Generate(5);
            Assert.AreEqual(5, name.Length);
        }

        [TestMethod]
        public void Sandpit()
        {
            var generator = new Generator();

            var emailAddress = generator.Generate(3, 10) + "." + generator.Generate(3, 10) + "@" + generator.Generate(3, 10) + ".com";
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Tests
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void ToCharArray_StringToCharArray_True()
        {
            char[] output = {'a','b','c'};
            string input = "abc";
            Converter newConverter = new Converter(input);
           
            Assert.AreEqual(output, newConverter.Input);
        }
    }
}
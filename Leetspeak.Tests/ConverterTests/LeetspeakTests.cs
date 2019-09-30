using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;
using System;

namespace Leetspeak.Tests
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void ToCharArray_StringToCharArray_True()
        {
            string input = "abc";
            char[] output = {'a','b','c'};
            Converter newConverter = new Converter(input);
            Assert.AreEqual(output[0], newConverter.Input[0]);
            
        }

        [TestMethod]
        public void CharConverter_Eto3_True()
        {
            string input = "ae";
            char output = '3';
            Converter newConverter = new Converter(input);
            Assert.AreEqual(output, newConverter.Input[1]);
        }

        [TestMethod]
        public void CharConverter_Oto0_True()
        {
            string input = "o";
            char output = '0';
            Converter newConverter = new Converter(input);
            Assert.AreEqual(output, newConverter.Input[0]);
        }

        [TestMethod]
        public void CharConverter_lto1_True()
        {
            string input = "l";
            char output = '1';
            Converter newConverter = new Converter(input);
            Assert.AreEqual(output, newConverter.Input[0]);
        }

        [TestMethod]
        public void CharConverter_tto7_True()
        {
            string input = "t";
            char output = '7';
            Converter newConverter = new Converter(input);
            Assert.AreEqual(output, newConverter.Input[0]);
        }

         [TestMethod]
        public void CharConverter_stoz_True()
        {
            string input = "1s";
            char output = 'z';
            Converter newConverter = new Converter(input);
            Assert.AreEqual(output, newConverter.Input[1]);
        }
    
    }
}
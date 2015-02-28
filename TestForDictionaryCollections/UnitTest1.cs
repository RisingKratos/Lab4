using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Lab4Exercise3;

namespace TestForLab4Exercise3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "5628623847256837542347852384567125412564317236";
            Assert.AreEqual("All input symbols are numbers", Program.Check(input));
        }
        [TestMethod]
        public void TestMethod2()
        {
            string input = "56412564317236";
            Assert.AreEqual("All input symbols are numbers", Program.Check(input));
        }
        [TestMethod]
        public void TestMethod3()
        {
            string input = "562dgjhsdf25412564317236";
            Assert.AreEqual("Not all input symbols are numbers", Program.Check(input));
        }
        [TestMethod]
        public void TestMethod4()
        {
            string input = "562-7-2ui2.9336";
            Assert.AreEqual("Not all input symbols are numbers", Program.Check(input));
        }
    }
}
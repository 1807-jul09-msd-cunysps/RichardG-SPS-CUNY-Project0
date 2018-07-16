using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classquiz;
using ClassLibrary1;

namespace UnitTestProject1

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string pall;
            string Input = "323";
            bool expected = true;
            Classlib.Pall("323");
            
        }
    }
}

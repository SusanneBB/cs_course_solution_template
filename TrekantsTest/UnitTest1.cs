using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module07_trekant;

namespace TrekantsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t1 = new Trekant(2, 2);
            Assert.IsTrue(t1.Areal == 2);
        }
    }
}

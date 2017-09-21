using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class UnitTestingSample
    {
        [TestMethod, TestCategory("Unit")]
        public void AdditionTest()
        {
            int result = Program.Addition(3, 5);


            Assert.AreEqual(8, result);

        }
    }
}

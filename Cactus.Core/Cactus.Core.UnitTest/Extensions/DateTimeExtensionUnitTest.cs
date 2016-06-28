using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cactus.Core.UnitTest
{
    [TestClass]
    public class DateTimeExtensionUnitTest
    {
        [TestMethod]
        public void ToBusinessStartDateTest()
        {
            var actual = new DateTime(2016, 8, 10);
            Assert.AreEqual(new DateTime(2016, 4, 1), actual);
        }
    }
}

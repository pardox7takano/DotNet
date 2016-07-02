using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Cactus.Core.UnitTest.Extensions
{
    /// <summary>
    /// <see cref="DateTimeExtension"/>型のテストクラス
    /// </summary>
    [TestClass]
    public class DateTimeExtensionUnitTest
    {
        /// <summary>
        /// <see cref="DateTimeExtension.ToBusinessStartDate(DateTime)"/>のテストメソッド。
        /// </summary>
        [TestMethod]
        public void ToBusinessStartDateTest()
        {
            var expected = new DateTime(2016, 4, 1);
            Assert.AreEqual(
                expected, new DateTime(2016, 4, 1).ToBusinessStartDate());
            Assert.AreEqual(
                expected, new DateTime(2016, 12, 31).ToBusinessStartDate());
            Assert.AreEqual(
                expected, new DateTime(2017, 1, 1).ToBusinessStartDate());
            Assert.AreEqual(
                expected, new DateTime(2017, 3, 31).ToBusinessStartDate());
        }
    }
}

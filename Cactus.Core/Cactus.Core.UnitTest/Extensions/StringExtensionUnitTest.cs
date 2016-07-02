using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus.Core.UnitTest.Extensions
{
    /// <summary>
    /// <see cref="StringExtension"/>型のテストクラス
    /// </summary>
    [TestClass]
    public class StringExtensionUnitTest
    {
        /// <summary>
        /// <see cref="StringExtension.ToDataTypeConvert{T}(string)"/>のテストメソッド。
        /// </summary>
        [TestMethod]
        public void ToDataTypeConvertTest()
        {
            Assert.AreEqual((int)1, "1".ToDataTypeConvert<int>());
            Assert.AreEqual((short)1, "1".ToDataTypeConvert<short>());
            Assert.AreEqual(new DateTime(2016, 1, 23), "2016/01/23".ToDataTypeConvert<DateTime>());
        }
    }
}

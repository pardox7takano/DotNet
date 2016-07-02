using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus
{
    /// <summary>
    /// <see cref="String"/>型の拡張メソッド。
    /// </summary>
    public static class StringExtension
    {
        #region ■ToDataTypeConvert<T>(string)
        /// <summary>
        /// 文字列を任意のデータ型へ変換し取得します。
        /// </summary>
        /// <typeparam name="T">任意のデータ型</typeparam>
        /// <param name="value">文字列</param>
        /// <returns>変換後の文字列</returns>
        public static T ToDataTypeConvert<T>(this string value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
        #endregion
    }
}

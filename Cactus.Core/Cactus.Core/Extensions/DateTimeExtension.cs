using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus
{
    /// <summary>
    /// <see cref="DateTime"/>型の拡張メソッド。
    /// </summary>
    public static class DateTimeExtension
    {
        #region ■ToBusinessStartDate
        /// <summary>
        /// 任意の日付の、年度開始日を取得します。
        /// </summary>
        /// <param name="value">年度開始日の日付</param>
        /// <returns>年度開始日</returns>
        public static DateTime ToBusinessStartDate(this DateTime value)
        {
            var result = new DateTime(value.Year, 4, 1);
            return value.Month < 4 ? result.AddYears(-1) : result;
        }
        #endregion
    }
}

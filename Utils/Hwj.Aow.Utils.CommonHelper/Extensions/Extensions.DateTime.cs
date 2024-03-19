using System;

namespace Hwj.Aow.Utils.CommonHelper.Extensions
{
    public static partial class Extensions
    {
        #region ToUnixTime

        /// <summary>
        /// dateTime转换为unixTime
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static int ToUnixTime(this DateTime @this)
        {
            var startTime = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1), TimeZoneInfo.Local);
            return (int)(@this - startTime).TotalSeconds;
        }

        #endregion ToUnixTime
    }
}
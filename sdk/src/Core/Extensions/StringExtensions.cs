using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Utils
{
    /// <summary>
    /// 字符串扩展类
    /// </summary>
    public static class StringExtensions
    {


        /// <summary>
        /// .net 3.5 IsNullOrWhiteSpace method
        /// </summary>
        /// <param name="value">string value</param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
#if NET35
            if (value == null)
            {
                return true;
            }

            return string.IsNullOrEmpty(value.Trim());
#else
            return string.IsNullOrWhiteSpace(value);
#endif
        }



        /// <summary>
        /// 首字母转换为大写
        /// </summary>
        /// <param name="str">需要进行转换的字符串</param>
        /// <returns>首字母转换为大写的结果</returns>
        public static string StringFirstCharToUpper(this string str)
        {
#if NET35
            if (str.IsNullOrWhiteSpace())

#else
            if (string.IsNullOrWhiteSpace(str))
#endif
            {
                return null;
            }
            else if (str.Length == 1)
            {
                return str.ToUpper();
            }
            else
            {
                var firstChar = str[0];

                str = $"{firstChar.ToString().ToUpper()}{str.Substring(1)}";
                return str;
            }

        }
    }
}

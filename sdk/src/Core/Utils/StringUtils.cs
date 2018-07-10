using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace JDCloudSDK.Core.Utils
{

    /// <summary>
    /// 字符串工具类
    /// </summary>
    public static class StringUtils
    {

        private const char CHAR_SPACE = ' ';
        private const char CHAR_TAB = '\t';
        private const char CHAR_NEW_LINE = '\n';
        private const char CHAR_VERTICAL_TAB = '\u000b';
        private const char CHAR_CARRIAGE_RETURN = '\r';
        private const char CHAR_FORM_FEED = '\f';

        /// <summary>
        /// 首字母转换为大写
        /// </summary>
        /// <param name="str">需要进行转换的字符串</param>
        /// <returns>首字母转换为大写的结果</returns>
        public static string StringFirstCharToUpper(this string str)
        {
#if NET35
            if (string.IsNullOrEmpty(str)||string.IsNullOrEmpty(str.Trim()))

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

        /// <summary>
        /// bytes 转换为 16进制字符串
        /// </summary>
        /// <param name="bytes">需要转换的字节数组</param>
        /// <param name="lowercase">大小写定义 true 小写 false 大写</param>
        /// <returns>转换后  16进制字符串</returns>
        public static string ByteToHex(byte[] bytes,bool lowercase=false)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString(lowercase ? "x2" : "X2", CultureInfo.InvariantCulture));
            } 
            return sb.ToString();

        }

        /// <summary>
        /// 字符串多空格去除拼接
        /// </summary>
        /// <param name="source">需要进行处理的字符串</param>
        /// <returns>进行处理的结果</returns>
        public static string AppendCompactedString( string source)
        {
            StringBuilder destination = new StringBuilder();
            bool previousIsWhiteSpace = false;
            int length = source.Length;

            for (int i = 0; i < length; i++)
            {
                char ch = source[i];
                if (Char.IsWhiteSpace(ch))
                {
                    if (previousIsWhiteSpace)
                    {
                        continue;
                    }
                    destination.Append(CHAR_SPACE);
                    previousIsWhiteSpace = true;
                }
                else
                {
                    destination.Append(ch);
                    previousIsWhiteSpace = false;
                }
            }
            return destination.ToString();
        }
    }
}

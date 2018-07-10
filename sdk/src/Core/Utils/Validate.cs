using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Core.Utils
{
    /// <summary>
    ///  字符串 验证函数
    /// </summary>
    public  class Validate
    {
        /// <summary>
        /// 默认的错误信息
        /// </summary>
        private const string DEFAULT_IS_NULL_EX_MESSAGE = "The validated object is null";

        /// <summary>
        /// 构造方法
        /// </summary>
        public Validate() { }


        /// <summary>
        /// 如果条件不为真，抛出异常信息
        /// </summary>
        /// <param name="expression">判断条件</param>
        /// <param name="message">格式化消息</param>
        /// <param name="values">消息传输的值</param>
        public static void IsTrue(bool expression, string message, params object[] values)
        {
            if (!expression)
            {
                throw new ArgumentException(string.Format(message, values));
            }
        }

        /// <summary>
        /// 判断对象不为空
        /// </summary>
        /// <param name="objectValue">需要判断的对象的值</param>
        /// <param name="message">消息字符串</param>
        /// <param name="values">消息的参数</param>
        /// <returns>判断后的对象</returns>
        public static T NotNull<T>( T objectValue,  string message, params object[] values)
        {
            if (objectValue == null)
            {
                throw new NullReferenceException(string.Format(message, values));
            }
            return objectValue;
        }

        /// <summary>
        /// 参数不为空
        /// </summary>
        /// <param name="objectValue">对象的值</param>
        /// <param name="paramName">参数名称</param>
        /// <returns>判断后的对象</returns>
        public static T ParamNotNull<T>(T objectValue, string paramName)
        {
            if (objectValue == null)
            { 
                throw new NullReferenceException( $"{paramName} must not be null" );
            }
            return objectValue;
        }

        /// <summary>
        /// 判断对象数组是否为空
        /// </summary>
        /// <param name="array">对象的数组</param>
        /// <param name="message">消息</param>
        /// <param name="values">值</param>
        /// <returns>判断后的数组</returns>
        public static  T[] NotEmpty<T>( T[] array,string message, params object[] values)
        {
            if (array == null)
            {
                throw new NullReferenceException(string.Format(message, values));
            }
            if (array.Length == 0)
            {
                throw new ArgumentException(string.Format(message, values));
            }
            return array;
        }

        /// <summary>
        /// 判断列表对象是否为空 
        /// </summary>
        /// <typeparam name="T">列表对象类型</typeparam>
        /// <param name="collection">列表对象</param>
        /// <param name="message">消息</param>
        /// <param name="values">消息参数</param>
        /// <returns>判断后的对象</returns>
        public static   T  NotEmpty<T>(  T collection, string message, params object[] values) where T:ICollection<T>
        {
            if (collection == null)
            {
                throw new NullReferenceException(String.Format(message, values));
            }
          
            if (collection.Count==0)
            {
                throw new ArgumentException(String.Format(message, values));
            }
            return collection;
        } 

    }
}

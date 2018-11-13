using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace JDCloudSDK.Core.Utils
{
    /// <summary>
    /// 通过用组建方法类
    /// </summary>
    public   class CommonUtils
    {
        /// <summary>
        /// 兼容方法 用反射获取数据
        /// </summary>
        /// <param name="propertyInfo">属性信息</param>
        /// <param name="value">实体类的值</param>
        /// <returns>通过反射获取属性得到的值</returns>
        public static object GetPropertyInfoValue(PropertyInfo propertyInfo,object value)
        {
#if NET35
            return propertyInfo.GetValue(value,null);
#else
            return propertyInfo.GetValue(value);
#endif
        }
    }
}

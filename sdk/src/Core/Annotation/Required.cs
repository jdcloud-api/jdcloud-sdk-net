using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Annotation
{
    /// <summary>
    /// 验证是否是必填属性标签
    /// </summary>
    [AttributeUsage(AttributeTargets.Field|AttributeTargets.Parameter|AttributeTargets.Property)]
    public  class RequiredAttribute: Attribute
    {
    }
}

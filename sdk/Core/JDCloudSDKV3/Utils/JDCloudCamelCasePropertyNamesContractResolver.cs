using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace JDCloudSDKV3.Utils
{
    /// <summary>
    /// 自定义json 对象序列化实例
    /// </summary>
    public  class JDCloudCamelCasePropertyNamesContractResolver : CamelCasePropertyNamesContractResolver
    {
        /// <summary>
        /// 创建json 属性序列化方法
        /// </summary>
        /// <param name="member">对象信息</param>
        /// <param name="memberSerialization">序列化信息</param>
        /// <returns>json 属性信息</returns>
        protected override JsonProperty CreateProperty(MemberInfo member,
                                                  MemberSerialization
                                                      memberSerialization)
        {
            var type = member.DeclaringType;
            var property = base.CreateProperty(member, memberSerialization);
            PropertyInfo[] classProps = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            //var inheritedProps = type.BaseType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var propContains = classProps.Select(p => p.Name).Contains(member.Name);
            if (propContains)
            {
#if NET40||NET35
                object attribute  = null;

                object[] attributes = classProps.Where(p => p.Name == member.Name).FirstOrDefault().GetCustomAttributes(false);
                if (attributes != null && attributes.Count() > 0)
                {
                    attribute = attributes.Where(p => p.GetType() == typeof(JsonIgnoreAttribute)).FirstOrDefault();
                }
#else
                var attribute = classProps.Where(p => p.Name == member.Name).FirstOrDefault().GetCustomAttribute(typeof(JsonIgnoreAttribute), false);
#endif
                if (attribute == null)
                {
                    property.Ignored = !propContains;
                }
            }
            return property;
        }
    }
}

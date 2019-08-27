using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;
using Newtonsoft.Json.Converters;
using System.Text.RegularExpressions;

namespace JDCloudSDK.Core.Utils
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


    /// <summary>
    /// process double type data ,if set integer value then convert to integer value
    /// </summary>
    public class CustomerDoubleNullConvert : CustomCreationConverter<double?>
    {
        /// <summary>
        /// override Can write
        /// </summary>
        public override bool CanWrite => true;
        /// <summary>
        /// override Create 
        /// </summary>
        /// <param name="objectType">object type</param>
        /// <returns></returns>
        public override double? Create(Type objectType)
        {
            return null;
        }

        /// <summary>
        /// write json data
        /// </summary>
        /// <param name="writer">json writer</param>
        /// <param name="value">object value</param>
        /// <param name="serializer">json serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            string result = value.ToString();
            if (value is double?&& value != null && ((double?)value).HasValue)
            {
                var temp = ((double?)value).Value.ToString("R");
                Regex regex = new Regex(@"^-?[0-9]\d*.?[0]+$"); 
                Regex regexInteger = new Regex(@"^-?[0-9]\d*$");
                if (regex.IsMatch(temp) || regexInteger.IsMatch(temp))
                {
                    var valueArray = temp.Split('.');
                    result = valueArray[0];
                    if (((double)value) < int.MaxValue)
                    {
                        writer.WriteValue(int.Parse(result));
                        
                    }
                    else if (((double)value) < long.MaxValue)
                    {
                        writer.WriteValue(long.Parse(result));
                         
                    }
                    else {
                        writer.WriteValue(value);
                         
                    }
                    return;
                   
                } 
            }
            writer.WriteValue(value);
            return;

        }

    }

    /// <summary>
    /// process double type data ,if set integer value then convert to integer value
    /// </summary>
    public class CustomerDoubleConvert : CustomCreationConverter<double>
    {
        /// <summary>
        /// override Can write
        /// </summary>
        public override bool CanWrite => true;
        /// <summary>
        /// override Create 
        /// </summary>
        /// <param name="objectType">object type</param>
        /// <returns></returns>
        public override double Create(Type objectType)
        {
            return 0.0;
        }

        /// <summary>
        /// write json data
        /// </summary>
        /// <param name="writer">json writer</param>
        /// <param name="value">object value</param>
        /// <param name="serializer">json serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            string result = value.ToString();
            if (value is double)
            {
                var temp = ((double)value).ToString("R");
                Regex regex = new Regex(@"^-?[0-9]\d*.?[0]+$");
                Regex regexInteger = new Regex(@"^-?[0-9]\d*$");
                if (regex.IsMatch(temp)|| regexInteger.IsMatch(temp))
                {
                    var valueArray = temp.Split('.');
                    result = valueArray[0];
                    if (((double)value) < int.MaxValue)
                    {
                        writer.WriteValue(int.Parse(result)); 
                    }
                    else if (((double)value) < long.MaxValue)
                    {
                        writer.WriteValue(long.Parse(result)); 
                    }
                    else
                    {
                        writer.WriteValue(value); 
                    }
                    return;
                } 
            }
            writer.WriteValue(value); 
        }
        
    }
}

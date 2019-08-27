using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Utils
{
    /// <summary>
    /// json 工具类
    /// </summary>
    public   class JsonUtil
    {
        /// <summary>
        /// 将 对象进行 json 格式化 转换为 小驼峰格式（.NET 默认类为大驼峰）
        /// </summary>
        /// <param name="data">要进行转换的对象</param>
        /// <returns>对象转换为小驼峰格式的json 字符串</returns>
        public static string ObjectToJson(object data)
        {
            var json = JsonConvert.SerializeObject(
            data,
            Formatting.None,
            new JsonSerializerSettings { ContractResolver = new JDCloudCamelCasePropertyNamesContractResolver(), Converters = { new CustomerDoubleConvert() ,new CustomerDoubleNullConvert() } }
            );

            return json;
        }
    }
}

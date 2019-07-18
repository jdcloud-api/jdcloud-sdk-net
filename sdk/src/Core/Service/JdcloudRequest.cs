using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Service
{
    /// <summary>
    /// 请求参数基类
    /// </summary>
    public  class JdcloudRequest
    {

        /// <summary>
        /// 请求的区域id
        /// </summary>
        [JsonIgnore]
        public virtual  string RegionId { get; set; }

        /// <summary>
        /// 请求的版本信息
        /// </summary>
        [JsonIgnore]
        public virtual string Version { get; set; }


    }
}

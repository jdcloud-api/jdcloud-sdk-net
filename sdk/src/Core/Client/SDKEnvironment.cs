using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Client
{
    /// <summary>
    /// 环境配置信息
    /// </summary>
    public class SDKEnvironment
    {
        /// <summary>
        /// 终节点
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// 真实终节点
        /// </summary>
        public string RealEndPoints { get; set; }

        /// <summary>
        /// 构造方法
        /// </summary>
        public SDKEnvironment()
        {

        }

        /// <summary>
        ///  构造方法
        /// </summary>
        /// <param name="endpoint">终结点信息字符串</param>
        public SDKEnvironment(string endpoint)
        {
            this.Endpoint = endpoint;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="endpoint">终节点信息</param>
        /// <param name="realEndPoints">真实终节点信息</param>
        public SDKEnvironment(string endpoint, string realEndPoints) : this(endpoint)
        {
            RealEndPoints = realEndPoints;
        }



    }
}

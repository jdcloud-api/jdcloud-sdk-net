using JDCloudSDK.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Config
{
    /// <summary>
    /// global config
    /// </summary>
    public class GlobalConfig
    {

        private static readonly GlobalConfig globalConfig = new GlobalConfig();

        static GlobalConfig() { }

        /// <summary>
        /// the jdsf SignVersionType default is v2 
        /// </summary>
        public JDCloudSignVersionType SignVersionType { get; set; } = JDCloudSignVersionType.JDCloud_V2;

        private GlobalConfig() { }

        /// <summary>
        /// get global config instance
        /// </summary>
        /// <returns></returns>
        public static GlobalConfig GetInstance() {
            return globalConfig;
        }

    }
}

using System;
using System.ComponentModel;

namespace JDCloudSDK.Core.Model
{

    /// <summary>
    /// jdcloud sign version type
    /// </summary>
    public enum JDCloudSignVersionType
    {
        /// <summary>
        /// jdcloud sign version 2.0
        /// </summary>
        [Description("JDCLOUD_V2")]
        JDCloud_V2,

        /// <summary>
        /// jdcloud sign version 3.0
        /// </summary>
        [Description("JDCLOUD_V3")]
        JDCloud_V3
    }
}

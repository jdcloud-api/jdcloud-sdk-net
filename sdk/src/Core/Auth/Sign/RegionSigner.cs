using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth.Sign
{

    /// <summary>
    /// Region 签名认证信息
    /// </summary>
    public interface RegionSigner:Signer
    {
        /// <summary>
        /// 设置region 信息
        /// </summary>
        /// <param name="regionName">要设置的region name</param>
        void SetRegionName(String regionName);
    }
}

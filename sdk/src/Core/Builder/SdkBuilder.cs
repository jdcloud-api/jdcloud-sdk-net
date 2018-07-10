using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Builder
{
    /// <summary>
    /// Builder 通用接口
    /// </summary>
    /// <typeparam name="T">需要构建的泛型对象</typeparam>
    public interface SdkBuilder<T>
    { 
        /// <summary>
        /// 构造的方法
        /// </summary>
        /// <returns>构建的泛型对象</returns>
        T Build();
    }
}

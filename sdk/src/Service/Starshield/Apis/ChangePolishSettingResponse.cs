/*
 * Copyright 2018 JDCLOUD.COM
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http:#www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * Zone Settings
 * A Zone setting changes how the Zone works in relation to caching, security, or other features of JDC StarShield
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Starshield.Apis
{

    /// <summary>
    ///  剥离元数据并压缩你的图像，以加快页面加载时间。
        ///         /// Basic（无损），减少PNG、JPEG和GIF文件的大小 - 对视觉质量没有影响。
        ///         /// Basic+JPEG（有损），进一步减少JPEG文件的大小，以加快图像加载。
        ///         /// 较大的JPEG文件被转换为渐进式图像，首先加载较低分辨率的图像，最后是较高的分辨率版本。
        ///         /// 不建议用于高像素的摄影网站。
        ///         /// 
    /// </summary>
    public class ChangePolishSettingResponse : JdcloudResponse<ChangePolishSettingResult>
    {
    }
}
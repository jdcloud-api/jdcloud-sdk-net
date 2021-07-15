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
 * 视频检测相关接口
 * API related to video scan
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


namespace  JDCloudSDK.Censor.Apis
{

    /// <summary>
    ///  视频检测结果获取接口，获取离线处理的数据后，下次调用，不会再次返回之前获取过的离线数据。小于10s/20次，请求频率过快服务器会拒绝处理
    /// </summary>
    public class VideoCallbackV2Response : JdcloudResponse<VideoCallbackV2Result>
    {
    }
}
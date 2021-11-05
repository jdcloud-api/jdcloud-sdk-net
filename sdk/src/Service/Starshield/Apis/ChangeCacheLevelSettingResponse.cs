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
    ///  缓存级别的功能是基于设置的级别。
        ///         /// basic设置将缓存大多数静态资源（即css、图片和JavaScript）。
        ///         /// simplified设置将在提供缓存的资源时忽略查询字符串。
        ///         /// aggressive设置将缓存所有的静态资源，包括有查询字符串的资源。
        ///         /// 
    /// </summary>
    public class ChangeCacheLevelSettingResponse : JdcloudResponse<ChangeCacheLevelSettingResult>
    {
    }
}
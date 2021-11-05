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
    ///  指定访问者在成功完成一项挑战（如验证码）后允许访问您的网站多长时间。在TTL过期后，访问者将不得不完成新的挑战。我们建议设置为15-45分钟，并将尝试遵守任何超过45分钟的设置。
        ///         /// 
    /// </summary>
    public class GetChallengeTTLSettingResponse : JdcloudResponse<GetChallengeTTLSettingResult>
    {
    }
}
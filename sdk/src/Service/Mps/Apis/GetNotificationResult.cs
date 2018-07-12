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
 * 媒体处理相关接口
 * 媒体处理API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Mps.Apis
{

    /// <summary>
    ///  获取截图通知
    /// </summary>
    public class GetNotificationResult : JdcloudResult
    {
        ///<summary>
        /// 是否启用通知
        ///</summary>
        public   bool Enabled{ get; set; }
        ///<summary>
        /// 通知endpoint, 当前支持http://和https://
        ///</summary>
        public   string Endpoint{ get; set; }
        ///<summary>
        /// 触发通知的事件集合 (mpsTranscodeComplete, mpsThumbnailComplete)
        ///</summary>
        public List<string> Events{ get; set; }

        ///<summary>
        /// 重试策略, BACKOFF_RETRY: 退避重试策略, 重试 3 次, 每次重试的间隔时间是 10秒 到 20秒 之间的随机值; EXPONENTIAL_DECAY_RETRY: 指数衰减重试, 重试 176 次, 每次重试的间隔时间指数递增至 512秒, 总计重试时间为1天; 每次重试的具体间隔为: 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 512 ... 512 秒(共167个512)
        ///</summary>
        public   string NotifyStrategy{ get; set; }
        ///<summary>
        /// 描述了向 Endpoint 推送的消息格式, JSON: 包含消息正文和消息属性, SIMPLIFIED: 消息体即用户发布的消息, 不包含任何属性信息
        ///</summary>
        public   string NotifyContentFormat{ get; set; }
    }
}
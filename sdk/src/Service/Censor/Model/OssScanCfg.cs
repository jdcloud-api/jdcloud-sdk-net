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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Censor.Model
{

    /// <summary>
    ///  ossScanCfg
    /// </summary>
    public class OssScanCfg
    {

        ///<summary>
        /// id标识,更新时传入，新增时传0
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 检测类型，increment-增量，stock-存量
        ///</summary>
        public string ScanType{ get; set; }
        ///<summary>
        /// 存量检测的开始时间，增量时无意义
        ///</summary>
        public int? StartTime{ get; set; }
        ///<summary>
        /// 存量检测的截止时间，增量时无意义
        ///</summary>
        public int? EndTime{ get; set; }
        ///<summary>
        /// 需要检测的oss bucket信息
        ///</summary>
        public List<BucketPrefixCfg> BucketsInfo{ get; set; }
        ///<summary>
        /// 冻结方式，policy-修改权限，remove-移动到备份文件夹
        ///</summary>
        public string FreezeAction{ get; set; }
        ///<summary>
        /// 图片配置
        ///</summary>
        public ScanConf ImageInfo{ get; set; }
        ///<summary>
        /// 视频配置
        ///</summary>
        public ScanConf VideoInfo{ get; set; }
        ///<summary>
        /// 文本配置
        ///</summary>
        public ScanConf TextInfo{ get; set; }
        ///<summary>
        /// 音频配置
        ///</summary>
        public ScanConf AudioInfo{ get; set; }
        ///<summary>
        /// 视频截帧配置, 暂不支持配置
        ///</summary>
        public FrameConf FrameInfo{ get; set; }
        ///<summary>
        /// 状态，0-检测中，1-暂停，2-完成，3-任务失败
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 任务开始时间
        ///</summary>
        public int? TaskStTime{ get; set; }
        ///<summary>
        /// 任务结束/中止时间
        ///</summary>
        public int? TaskEndTime{ get; set; }
    }
}

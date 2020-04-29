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


namespace JDCloudSDK.Mps.Model
{

    /// <summary>
    ///  截图任务信息
    /// </summary>
    public class SnapshotTaskObject
    {

        ///<summary>
        /// 任务ID
        ///</summary>
        public string TaskId{ get; set; }
        ///<summary>
        /// 截图起始时间
        ///</summary>
        public int? StartTime{ get; set; }
        ///<summary>
        /// 截图帧类型。
        ///</summary>
        public string FrameType{ get; set; }
        ///<summary>
        /// 截图格式。取值范围：jpg、png
        ///</summary>
        public string Format{ get; set; }
        ///<summary>
        /// 截图数量
        ///</summary>
        public int? Number{ get; set; }
        ///<summary>
        /// 截图间隔
        ///</summary>
        public int? Interval{ get; set; }
        ///<summary>
        /// 截图宽度
        ///</summary>
        public int? Width{ get; set; }
        ///<summary>
        /// 截图高度
        ///</summary>
        public int? Height{ get; set; }
        ///<summary>
        /// 填充方式
        ///</summary>
        public string FillType{ get; set; }
        ///<summary>
        /// 输入配置
        ///</summary>
        public Input Input{ get; set; }
        ///<summary>
        /// 输出配置
        ///</summary>
        public Output Output{ get; set; }
        ///<summary>
        /// 雪碧图参数配置
        ///</summary>
        public SpriteConfig SpriteConfig{ get; set; }
        ///<summary>
        /// 雪碧图输出配置
        ///</summary>
        public Output SpriteOutput{ get; set; }
        ///<summary>
        /// 任务状态。
        /// - submitted
        /// - cancelled
        /// - running
        /// - finished_success
        /// - finished_failure
        /// 
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 完成时间
        ///</summary>
        public DateTime? FinishTime{ get; set; }
    }
}

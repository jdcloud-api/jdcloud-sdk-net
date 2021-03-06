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
    ///  修改截图模板请求信息
    /// </summary>
    public class UpdateSnapshotTemplateRequestInfo
    {

        ///<summary>
        /// 模板标题。长度不超过 128 个字节。UTF-8 编码。
        ///</summary>
        public string Title{ get; set; }
        ///<summary>
        /// 截图起始时间，单位为秒，缺省值为 0
        ///</summary>
        public int? StartTime{ get; set; }
        ///<summary>
        /// 截图帧类型。取值范围：normal、intra
        ///</summary>
        public string FrameType{ get; set; }
        ///<summary>
        /// 截图格式。取值范围：jpg、png
        ///</summary>
        public string Format{ get; set; }
        ///<summary>
        /// 截图数量，缺省值为 10
        ///</summary>
        public int? Number{ get; set; }
        ///<summary>
        /// 截图间隔
        ///</summary>
        public int? Interval{ get; set; }
        ///<summary>
        /// 截图宽度，取值范围：[8, 4096]
        /// 
        ///</summary>
        public int? Width{ get; set; }
        ///<summary>
        /// 截图高度，取值范围：[8, 4096]
        /// 
        ///</summary>
        public int? Height{ get; set; }
        ///<summary>
        /// 填充方式，当视频宽高与截图宽高指定值不能匹配时的填充处理方式。取值范围：
        ///   stretch - 伸缩
        ///   black - 留黑
        ///   white - 留白
        ///   gauss - 高斯模糊
        /// 缺省值为 black
        /// 
        ///</summary>
        public string FillType{ get; set; }
        ///<summary>
        /// 雪碧图配置
        ///</summary>
        public SpriteConfig SpriteConfig{ get; set; }
    }
}

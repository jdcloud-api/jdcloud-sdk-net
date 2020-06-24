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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Mps.Model
{

    /// <summary>
    ///  雪碧图配置
    /// </summary>
    public class SpriteConfig
    {

        ///<summary>
        /// 雪碧图小图行数。雪碧图行列积必须不大于100
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public int Rows{ get; set; }
        ///<summary>
        /// 雪碧图小图列数。雪碧图行列积必须不大于100
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public int Columns{ get; set; }
        ///<summary>
        /// 雪碧图单元格宽度
        /// 取值范围：[8, 4096]，不能为奇数
        /// 未设置时，回退为截图宽度 width
        /// 
        ///</summary>
        public int? CellWidth{ get; set; }
        ///<summary>
        /// 雪碧图单元格高度，
        /// 取值范围：[8, 4096]，不能为奇数
        /// 未设置时，系统自动会自动设置为截图高度 height
        /// 
        ///</summary>
        public int? CellHeight{ get; set; }
        ///<summary>
        /// 是否保留截图
        /// 雪碧图的截图方式是先截取普通图，然后合成雪碧图。此字段控制是否保留截图。
        /// 
        ///</summary>
        public bool DoKeepShots{ get; set; }
    }
}
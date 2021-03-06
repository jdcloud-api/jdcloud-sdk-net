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


namespace JDCloudSDK.Jdccs.Model
{

    /// <summary>
    ///  机房巡检
    /// </summary>
    public class IdcInspection
    {

        ///<summary>
        /// 巡检时间,UTC时间
        ///</summary>
        public string InspectionTime{ get; set; }
        ///<summary>
        /// 温度数值
        ///</summary>
        public string Temperature{ get; set; }
        ///<summary>
        /// 湿度数值
        ///</summary>
        public string Humidity{ get; set; }
        ///<summary>
        /// 物品摆放
        ///</summary>
        public string GoodsPlacement{ get; set; }
        ///<summary>
        /// 漏水
        ///</summary>
        public string LeakWater{ get; set; }
        ///<summary>
        /// 门禁
        ///</summary>
        public string AccessControl{ get; set; }
        ///<summary>
        /// 安防（监控）
        ///</summary>
        public string Monitor{ get; set; }
        ///<summary>
        /// 消防
        ///</summary>
        public string Fire{ get; set; }
        ///<summary>
        /// 防雷
        ///</summary>
        public string Thunder{ get; set; }
        ///<summary>
        /// 空调
        ///</summary>
        public string AirConditioning{ get; set; }
        ///<summary>
        /// UPS
        ///</summary>
        public string Ups{ get; set; }
        ///<summary>
        /// 供电
        ///</summary>
        public string Power{ get; set; }
        ///<summary>
        /// 物理环境异常描述
        ///</summary>
        public string PhysicalEnv{ get; set; }
    }
}

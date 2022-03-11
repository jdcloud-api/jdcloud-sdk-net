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


namespace JDCloudSDK.Smartdba.Model
{

    /// <summary>
    ///  supportMetric
    /// </summary>
    public class SupportMetric
    {

        ///<summary>
        /// 指标对应的id，用来修改监控项传递给后端使用的参数
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 监控项中文名
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 指标项英文名，用来从后端获取具体指标结果的参数
        ///</summary>
        public string Metric{ get; set; }
        ///<summary>
        /// 单位
        ///</summary>
        public string CalculateUnit{ get; set; }
    }
}

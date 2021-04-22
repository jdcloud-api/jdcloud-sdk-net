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
    ///  开放设备数据信息列表
    /// </summary>
    public class Point
    {

        ///<summary>
        /// 数据点名称
        ///</summary>
        public string PointName{ get; set; }
        ///<summary>
        /// 数据点数据
        ///</summary>
        public double? PointData{ get; set; }
        ///<summary>
        /// 数据点标签 currentA A支路电流 currentB B支路电流 powerA A支路功率 powerB B支路功率 voltageA A支路电压 voltageB B支路电压 temperature温度 humidity湿度 averageVoltage三相平均相电压 totalPower总功率 totalCurrent总电流
        ///</summary>
        public string PointTag{ get; set; }
    }
}

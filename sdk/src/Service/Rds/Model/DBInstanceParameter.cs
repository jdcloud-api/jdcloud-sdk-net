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


namespace JDCloudSDK.Rds.Model
{

    /// <summary>
    ///  dBInstanceParameter
    /// </summary>
    public class DBInstanceParameter
    {

        ///<summary>
        /// 参数名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 参数描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 参数修改后的数值，但不一定生效，需要视该参数生效是否需要重启
        ///</summary>
        public string ConfigureValue{ get; set; }
        ///<summary>
        /// 当前在实例中生效的数值
        ///</summary>
        public string RunningValue{ get; set; }
        ///<summary>
        /// 该参数数值的允许范围
        ///</summary>
        public string Range{ get; set; }
        ///<summary>
        /// 修改是否需要重启生效.- true:参数需要重启才能生效- false:参数生效无需重启
        ///</summary>
        public string NeedRestart{ get; set; }
    }
}
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
    ///  sFaceData
    /// </summary>
    public class SFaceData
    {

        ///<summary>
        /// 以图片左上角为坐标原点，logo区域左上角到y轴距离
        ///</summary>
        public double? X{ get; set; }
        ///<summary>
        /// 以图片左上角为坐标原点，logo区域左上角到x轴距离
        ///</summary>
        public double? Y{ get; set; }
        ///<summary>
        /// logo区域宽度
        ///</summary>
        public double? W{ get; set; }
        ///<summary>
        /// logo区域高度
        ///</summary>
        public double? H{ get; set; }
        ///<summary>
        /// 识别出的人脸信息，具体结构描述见face
        ///</summary>
        public List<Face> Faces{ get; set; }
    }
}

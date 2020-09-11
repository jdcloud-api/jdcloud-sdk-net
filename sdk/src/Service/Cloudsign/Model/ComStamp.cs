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


namespace JDCloudSDK.Cloudsign.Model
{

    /// <summary>
    ///  comStamp
    /// </summary>
    public class ComStamp
    {

        ///<summary>
        /// 盖章类型（0 坐标 1 关键字）
        ///</summary>
        public int? SignPositionType{ get; set; }
        ///<summary>
        /// 盖章关键字（与坐标二选一）
        ///</summary>
        public string Keyword{ get; set; }
        ///<summary>
        /// 盖章X坐标（与关键字二选一）
        ///</summary>
        public int? PositionX{ get; set; }
        ///<summary>
        /// 盖章Y坐标（与关键字二选一）
        ///</summary>
        public int? PositionY{ get; set; }
        ///<summary>
        /// 盖章X坐标偏移量（配合positionX）
        ///</summary>
        public int? OffsetX{ get; set; }
        ///<summary>
        /// 盖章Y坐标偏移量（配合positionY）
        ///</summary>
        public int? OffsetY{ get; set; }
        ///<summary>
        /// 盖章页码（选择坐标盖章时需要）
        ///</summary>
        public int? Page{ get; set; }
        ///<summary>
        /// 印章名称
        ///</summary>
        public string SealName{ get; set; }
        ///<summary>
        /// 印章图像base64(建议png格式,不传使用默认圆形章)
        ///</summary>
        public string ImageB64{ get; set; }
        ///<summary>
        /// 印章ID
        ///</summary>
        public string StampId{ get; set; }
        ///<summary>
        /// 印章描述
        ///</summary>
        public string Desc{ get; set; }
        ///<summary>
        /// 是否作为以后签章默认章
        ///</summary>
        public bool IsDefault{ get; set; }
        ///<summary>
        /// 图片类型，只支持png格式
        ///</summary>
        public string ImageType{ get; set; }
        ///<summary>
        /// 图片大小，高度*宽度
        ///</summary>
        public int? ImageSize{ get; set; }
        ///<summary>
        /// 图片高度
        ///</summary>
        public int? ImageHeight{ get; set; }
        ///<summary>
        /// 图片宽度
        ///</summary>
        public int? ImageWidth{ get; set; }
        ///<summary>
        /// 公司名称
        ///</summary>
        public string OrgName{ get; set; }
        ///<summary>
        /// 法人姓名
        ///</summary>
        public string LegalPersonName{ get; set; }
        ///<summary>
        /// 代办人姓名
        ///</summary>
        public string TransactorName{ get; set; }
        ///<summary>
        /// 代办人身份证号码
        ///</summary>
        public string TransactorIdCardNum{ get; set; }
        ///<summary>
        /// 代办人手机号
        ///</summary>
        public string TransactorMobile{ get; set; }
        ///<summary>
        /// 标记字段 - usci(统一社会信用码) orgCode（组织机构代码） businessNum （工商营业执照号）
        ///</summary>
        public string IdentifyType{ get; set; }
        ///<summary>
        /// 标记值
        ///</summary>
        public string IdentifyValue{ get; set; }
    }
}

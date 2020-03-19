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
    ///  ossScanReviewReq
    /// </summary>
    public class OssScanReviewReq
    {

        ///<summary>
        /// 审核结果，blockDelete-违规并删除 normalIgnore-正常并忽略 normalRecover-正常并恢复
        ///</summary>
        public string Result{ get; set; }
        ///<summary>
        /// taskId
        ///</summary>
        public List<string> TaskIds{ get; set; }
    }
}

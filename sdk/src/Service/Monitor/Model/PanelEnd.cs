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


namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  panelEnd
    /// </summary>
    public class PanelEnd
    {

        ///<summary>
        /// 该panel所属dashboard的uid
        ///</summary>
        public string DashboardUid{ get; set; }
        ///<summary>
        /// 该panel所属维度
        ///</summary>
        public string Dimension{ get; set; }
        ///<summary>
        /// 该panel包含的metric
        ///</summary>
        public List<PanelMetric> PanelMetrics{ get; set; }
        ///<summary>
        /// 该panel的名字
        ///</summary>
        public string PanelName{ get; set; }
        ///<summary>
        /// PanelPosition
        ///</summary>
        public PanelPosition PanelPosition{ get; set; }
        ///<summary>
        /// 资源id列表
        ///</summary>
        public List<PanelResource> PanelResources{ get; set; }
        ///<summary>
        /// 标签服务列表
        ///</summary>
        public List<PanelTagResource> PanelTagResources{ get; set; }
        ///<summary>
        /// topN的数量，图表类型为3(topN表格)时有效
        ///</summary>
        public long? PanelTopNum{ get; set; }
        ///<summary>
        /// 该panel的类型，1-折线图(明细);2-折线图(汇总);3-topN表格
        ///</summary>
        public long? PanelType{ get; set; }
        ///<summary>
        /// 该panel的uid
        ///</summary>
        public string PanelUid{ get; set; }
        ///<summary>
        /// 该panel所属产品
        ///</summary>
        public string Product{ get; set; }
        ///<summary>
        /// 依据tag过滤
        ///</summary>
        public List<TagFilter> Tags{ get; set; }
    }
}
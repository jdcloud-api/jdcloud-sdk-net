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
 * 域名操作类接口
 * Openapi For JCLOUD cdn
 *
 * OpenAPI spec version: v1
 * Contact: pid-cdn@jd.com
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  添加httpHeader
    /// </summary>
    public class SetHttpHeaderRequest : JdcloudRequest
    {
        ///<summary>
        /// 0表示header在边缘生效，1表示header回源生效，2表示在边缘和回源都生效，该字段不传时默认header在边缘和回源都生效
        ///</summary>
        public   int? EdgeType{ get; set; }
        ///<summary>
        /// header类型[resp,req],resp：配置响应头，req：配置请求头
        ///</summary>
        public   string HeaderType{ get; set; }
        ///<summary>
        /// header名，例如：Content-Disposition，可自定义，长度不能超过256个字符，不能包含中文字符，不能包含$和_，不支持设置如下头名：[&quot;Content-Length&quot;,&quot;Date&quot;,&quot;Host&quot;,&quot;Content-Encoding&quot;,&quot;If-Modified-Since&quot;,&quot;If-Range&quot;,&quot;Content-Type&quot;,&quot;Transfer-Encoding&quot;,&quot;Cache-Control&quot;,&quot;Last-Modified&quot;,&quot;Connection&quot;, &quot;Content-Range&quot;,&quot;ETag&quot;,&quot;Age&quot;,&quot;Authentication-Info&quot;,&quot;Proxy-Authenticate&quot;,&quot;Retry-After&quot;,&quot;Set-Cookie&quot;,&quot;Vary&quot;,&quot;Content-Location&quot;,&quot;Meter&quot;,&quot;Allow&quot;,&quot;Error&quot;,&quot;X-Trace&quot;, &quot;Proxy-Connection&quot;]
        ///</summary>
        public   string HeaderName{ get; set; }
        ///<summary>
        /// header值，不能包含($,_,#)，不能超过256个字符
        ///</summary>
        public   string HeaderValue{ get; set; }
        ///<summary>
        /// 用户域名
        ///Required:true
        ///</summary>
        [Required]
        public   string Domain{ get; set; }
    }
}
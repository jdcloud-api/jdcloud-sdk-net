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


namespace JDCloudSDK.Bri.Model
{

    /// <summary>
    ///  creditTaskLoginDetail
    /// </summary>
    public class CreditTaskLoginDetail
    {

        ///<summary>
        /// 注册手机号，国内手机：11位手机号;海外手机：以+号开头，4位国家代码+5-11位手机号扩展位；手机注册，必填
        ///</summary>
        public string Phone{ get; set; }
        ///<summary>
        /// 登录IP，用户登录IP，IPV4 或 IPV6
        ///</summary>
        public string LoginIp{ get; set; }
        ///<summary>
        /// 登录认证方式，1：手动帐号密码输入；2：动态短信密码登录；3：二维码扫描登录；0其他
        ///</summary>
        public string LoginType{ get; set; }
        ///<summary>
        /// 登录账号名pin，用户登录使用名称
        ///</summary>
        public string LoginName{ get; set; }
        ///<summary>
        /// 注册渠道或注册终端，1：PC端web浏览器注册 PC-Brower；2：PC客户端注册 PC-Client；3：移动设备各种APP注册 Mobile-APP；4 ：移动设备浏览器登录，移动端M页注册 Mobile-Brower；5：移动设备微信客户端中购物入口的注册操作 Mobile-WX；6： 移动设备QQ客户端中购物入口的注册操作 Mobile-QQ；7： 移动设备微信客户端中微信小程序注册操作- Mobile-WX；0：其他
        ///</summary>
        public int? Channel{ get; set; }
        ///<summary>
        /// 应用设备名称，PC 端：如果为浏览器说明浏览器名称 IE、firefox、chrome等;移动APP端：请说明移动APP名称
        ///</summary>
        public string DeviceName{ get; set; }
        ///<summary>
        /// 应用设备版本，跟deviceName关联，说明deviceName对应的版本
        ///</summary>
        public string DeviceVersion{ get; set; }
        ///<summary>
        /// 设备操作系统，说明设备的操作系统，如windows ，openSUSE、debian、ubuntu，unix, android, ios 等。
        ///</summary>
        public string DeviceOS{ get; set; }
        ///<summary>
        /// 设备操作系统版本，说明设备的操作系统版本，跟deviceOs 字段关联，例如deviceOs为android，此处可以为 3.0，4.0，4.2，5.0 等。
        ///</summary>
        public string DeviceOSVersion{ get; set; }
        ///<summary>
        /// 登录时间，用户登录完成时间，UNIX时间戳
        ///</summary>
        public long? LoginTime{ get; set; }
        ///<summary>
        /// 登录占用时长，从出登录页到登录提交之间的时间差（出登录视图埋点，提交时计算时间差），如果为免密码登录方式，可以在换取认证token时生成时间戳，验证token时计算时间差，单位ms
        ///</summary>
        public string ElapsedTime{ get; set; }
        ///<summary>
        /// 登录结果，1：登录成功；2： 用户不存在，无法登录；3 ：密码错误，无法登录；4： 密码错误，账号被锁定；5： 账号未通过审核，无法登录；6：账号审核中，无法登录；7：账号锁定，无法登录；8： 账号已注销，无法登录；9：短信验证码错误，无法登录；10：风险账号，无法登录；11：验证码错误，无法登录；0：其他；
        ///</summary>
        public string LoginResult{ get; set; }
        ///<summary>
        /// 登录邮箱，用户登录邮箱，可选参数
        ///</summary>
        public string LoginEmail{ get; set; }
        ///<summary>
        /// MAC地址，MAC 地址或设备唯一标识。
        ///</summary>
        public string MacAddress{ get; set; }
        ///<summary>
        /// 手机设备号，Android：imei，IOS：idfa
        ///</summary>
        public string Imei{ get; set; }
        ///<summary>
        /// 手机设备号，Android：imei，IOS：idfa
        ///</summary>
        public string Idfa{ get; set; }
        ///<summary>
        /// 注册ip，用户注册IP，IPV4 或 IPV
        ///</summary>
        public string RegIp{ get; set; }
        ///<summary>
        /// 设备ID，设备指纹编码
        ///</summary>
        public string Eid{ get; set; }
        ///<summary>
        /// 注册时间，用户注册完成时间，UNIX时间戳
        ///</summary>
        public int? RegTime{ get; set; }
        ///<summary>
        /// 业务类型，1、个人；2、商家；3、企业；4、其他
        ///</summary>
        public string BizType{ get; set; }
        ///<summary>
        /// 认证方式，1 - PC 用户名/登录名+密码登录；2 - PC 关联手机号+密码登录；3 - PC 邮箱+密码登录；5 - 手机APP扫码授权登录其他终端（PC、TV、PAD、冰箱等）；6-（APP &amp; M &amp; WX &amp; QQ、微信小程序、快应用）账号+密码登录；15-刷脸登录；
        ///</summary>
        public string AuthType{ get; set; }
        ///<summary>
        /// 接入登录应用Id，仅APP登录时提供，说明接入京东登录的应用标识
        ///</summary>
        public string AppId{ get; set; }
        ///<summary>
        /// 手机品牌，如果手机注册，请带上此信息
        ///</summary>
        public string MobileBrand{ get; set; }
        ///<summary>
        /// App 客户端版本
        ///</summary>
        public string AppVersion{ get; set; }
        ///<summary>
        /// 用户操作过程中鼠标单击次数
        ///</summary>
        public int? MouseClickCount{ get; set; }
        ///<summary>
        /// 用户操作过程中键盘单击次数
        ///</summary>
        public int? KeyboardClickCount{ get; set; }
        ///<summary>
        /// 用户 HTTP 请求的 referer 值
        ///</summary>
        public string Referer{ get; set; }
        ///<summary>
        /// 登录成功后跳转页面
        ///</summary>
        public string JumpUrl{ get; set; }
        ///<summary>
        /// 用户 HTTP 请求的 userAgent
        ///</summary>
        public string UserAgent{ get; set; }
        ///<summary>
        /// 用户 HTTP 请求中的 x_forward_for
        ///</summary>
        public string XForwardedFor{ get; set; }
    }
}

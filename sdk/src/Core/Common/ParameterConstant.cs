using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Common
{
    /// <summary>
    /// 静态参数类
    /// </summary>
    public static class ParameterConstant
    {


        /// <summary>
        /// 默认的编码格式UTF-8
        /// </summary>
        public static readonly Encoding DEFAULT_ENCODING = Encoding.UTF8;
        /// <summary>
        /// 格式化信息
        /// </summary>
        public const string FORMAT = "Format";

        /// <summary>
        /// Action
        /// </summary>
        public const string ACTION = "Action";

        /// <summary>
        /// AccessKeyId
        /// </summary>
        public const string ACCESSKEYID = "AccessKeyId";

        /// <summary>
        /// 时间戳
        /// </summary>
        public const string TIMESTAMP = "TimeStamp";

        /// <summary>
        /// Nonce
        /// </summary>
        public const string NONCE = "Nonce";

        /// <summary>
        /// 签名方法
        /// </summary>
        public const string SIGNATUREMETHOD = "SignatureMethod";

        /// <summary>
        /// s key
        /// </summary>
        public const string SECRETACCESSKEY = "SecretAccessKey";

        /// <summary>
        /// 地域
        /// </summary>
        public const string REGION = "Region";

        /// <summary>
        /// 签名版本
        /// </summary>
        public const string SIGNATUREVERSION = "SignatureVersion";

        /// <summary>
        /// 版本号
        /// </summary>
        public const string VERSION = "Version";

        /// <summary>
        /// 安全令牌
        /// </summary>
        public const string SECURITYTOKEN = "SecurityToken";

        /// <summary>
        /// 方法类型
        /// </summary>
        public const string METHODTYPE = "MethodType";

        /// <summary>
        /// 签名
        /// </summary>
        public const string SIGNATURE = "Signature";

        /// <summary>
        /// Jdcloud  Algorithm
        /// </summary>
        public const string X_JDCLOUD_ALGORITHM = "X-Jdcloud-Algorithm";

        /// <summary>
        /// Jdcloud Credential
        /// </summary>
        public const string X_JDCLOUD_CREDENTIAL = "X-Jdcloud-Credential";

        /// <summary>
        /// 请求日期
        /// </summary>
        public const string X_JDCLOUD_DATE = "X-Jdcloud-Date";

        /// <summary>
        /// Jdcloud Nonce
        /// </summary>
        public const string X_JDCLOUD_NONCE = "X-Jdcloud-Nonce";

        /// <summary>
        /// Jdcloud SignedHeaders
        /// </summary>
        public const string X_JDCLOUD_SIGNEDHEADERS = "X-Jdcloud-SignedHeaders";


        /// <summary>
        /// Jdcloud Signature
        /// </summary>
        public const string X_JDCLOUD_SIGNATURE = "X-Jdcloud-Signature";

        /// <summary>
        /// 验证域名
        /// </summary>
        public const string DOMAIN = ".jdcloud-api.com";

        /// <summary>
        /// 区域id
        /// </summary>
        public const string REGIONID = "RegionId";

        /// <summary>
        /// 服务名称
        /// </summary>
        public const string SERVICE_NAME = "service-name";

        /// <summary>
        /// Content Type
        /// </summary>
        public const string CONTENT_TYPE = "Content-Type";

        /// <summary>
        /// Content Length
        /// </summary>
        public const string CONTENT_LENGTH = "Content-Length";

        /// <summary>
        /// Jdcloud  Security Token
        /// </summary>
        public const string X_JDCLOUD_SECURITY_TOKEN = "X-Jdcloud-Security-Token";


        /// <summary>
        /// JDCLOUD 签名算法
        /// </summary>
        public const string JDCLOUD2_SIGNING_ALGORITHM = "JDCLOUD2-HMAC-SHA256";

        /// <summary>
        /// 请求逾期时间
        /// </summary>
        public const string X_JDCLOUD_EXPIRES = "X-Jdcloud-Expires";

        /// <summary>
        /// Jdcloud 签名头
        /// </summary>
        public const string X_JDCLOUD_SIGNED_HEADER = "X-Jdcloud-SignedHeaders";

        /// <summary>
        /// jdcloud content sha256
        /// </summary>
        public const string X_JDCLOUD_CONTENT_SHA256 = "x-jdcloud-content-sha256";

        /// <summary>
        /// Authorition头
        /// </summary>
        public const string AUTHORIZATION = "Authorization";

        /// <summary>
        /// 换行符号
        /// </summary>
        public const string LINE_SEPARATOR = "\n";

        /// <summary>
        /// jdcloud2_request
        /// </summary>
        public const string JDCLOUD_TERMINATOR = "jdcloud2_request";

        /// <summary>
        /// Host
        /// </summary>
        public const string HOST = "Host";


        /// <summary>
        /// 用户pin head
        /// </summary>
        public const string JDCLOUD_PIN = "x-jdcloud-pin";

        /// <summary>
        /// erp 认证信息
        /// </summary>
        public const string JDCLOUD_ERP = "x-jdcloud-erp";


        /// <summary>
        /// 时间格式化字符串信息
        /// </summary>
        public const string DATA_TIME_FORMAT = "yyyyMMdd'T'HHmmss'Z'";


        /// <summary>
        /// 头部验证时间格式化方式
        /// </summary>
        public const string HEADER_DATA_FORMAT = "yyyyMMdd";

        /// <summary>
        /// 默认的字符编码类型  "UTF-8"
        /// </summary>
        public const string CHARSET = "UTF-8";

        /// <summary>
        /// 进行正则匹配的 pattern
        /// </summary>
        public const string PATTERN = "\\{([a-zA-Z0-9-_]+)}";

        /// <summary>
        /// URL 字符替换正则表达式
        /// </summary>
        public const string URL_ENCODE_PATTERN = @"%[a-f0-9]{2}";

        /// <summary>
        /// Api 请求 content type 定义
        /// </summary>
        public const string MIME_JSON = "application/json";


        /// <summary>
        /// HmacSHA1签名方法
        /// </summary>
        public const string SIGN_SHA1 = "HMACSHA1";

        /// <summary>
        /// HmacSHA256签名方法
        /// </summary>
        public const string SIGN_SHA256 = "HMACSHA256";

        /// <summary>
        /// the sdk default request region
        /// </summary>
        public const string DEFAULT_REGION = "cn-north-1";
    }
}

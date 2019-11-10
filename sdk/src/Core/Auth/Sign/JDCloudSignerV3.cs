using System;
using System.Collections.Generic;
using JDCloudSDK.Core.Model;
using System.Linq;
using JDCloudSDK.Core.Utils;

namespace JDCloudSDK.Core.Auth.Sign
{
    public class JDCloudSignerV3 : IJDCloudSigner
    {

        private static readonly string[] REQUEST_METHOD = { "GET","POST","PUT","HEAD","PATCH", "DELETE", "CONNECT", "OPTIONS", "TRACE" };

        private static readonly string[] NOT_SIGN_REQUEST_HEAD = { "cache-control","content-type","content-length",
            "host","expect","max-forwards","pragma","range","te","if-match","if-none-match","if-modified-since","if-unmodified-since","if-range",
            "accept","authorization","proxy-authorization","from","referer","user-agent","x-jdcloud-request-id"};

        public JDCloudSignerV3()
        {
        }

        public SignedRequestModel Sign(RequestModel requestModel, Credential credentials)
        {
            return null;
        }

        public SignedRequestModel Sign(string requestUrl, string serviceName, string httpRequestMethod,
            string regionName, string apiVersion, Credential credentials, byte[] content, string contentType,
            Dictionary<string, List<string>> header, DateTime? overrddenDate = null)
        {
            httpRequestMethod = ProcessRequestMethod(httpRequestMethod);
            if ( requestUrl.IsNullOrWhiteSpace()) {
                throw new ArgumentNullException($"param requestUrl can not be null or empty");
            }



            return null;
        }



        private static string ProcessRequestMethod(string requestMethod) {

            if ( requestMethod.IsNullOrWhiteSpace()) {
                return requestMethod;
            }

            requestMethod = requestMethod.ToUpper();

            if (!REQUEST_METHOD.Contains(requestMethod)) {
                throw new ArgumentException($" request method :{requestMethod} not support");
            }

            return requestMethod;
        }

    }
}

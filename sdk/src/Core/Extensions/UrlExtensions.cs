using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace JDCloudSDK.Core.Extensions
{
    /// <summary>
    /// url Extensions
    /// </summary>
    public static class UrlExtensions
    {

        private const string REGION_PATTERN = @"^[a-z0-9-]+";
        private const string HOST_PATTERN = @"^([a-zA-Z0-9]+)\.jdcloud-api.com";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public static string GetServiceName(this Uri requestUri) {
            string host = requestUri.Host;
            if (Regex.IsMatch(host, HOST_PATTERN))
            {
                var hostArray = host.Split('.');
                if (hostArray != null && hostArray.Length > 0) {
                    return hostArray[0];
                }
            }
            return string.Empty;
        }
        /// <summary>
        /// get request region info
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public static string GetRequestRegion(this Uri requestUri) {
            string requestPath = requestUri.AbsolutePath;
            var pathArray = requestPath.Split('/');
            if (pathArray.Length > 0) {
                for (int i = 0; i < pathArray.Length; i++)
                {
                    if (pathArray[i] == "regions"||pathArray[i].ToLower() == "regions") {
                        if (i + 1 < pathArray.Length) {
                            string region = pathArray[i + 1];
                             if (Regex.IsMatch(region,REGION_PATTERN)) {
                                return region;
                            }
                        } 
                    }
                }
            } 
            return string.Empty;
        }

        /// <summary>
        /// get jdcloud request uri content version 
        /// </summary>
        /// <param name="requestUri">the http request uri </param>
        /// <returns>the request api version</returns>
        public static string GetRequestVersion(this Uri requestUri) {
            string requestPath = requestUri.AbsolutePath;
            var pathArray = requestPath.Split('/');
            if (pathArray.Length > 1) {
                var versionString = pathArray[0];
                if (versionString.Trim().StartsWith("v") || versionString.StartsWith("V")) {
                    return versionString.Trim();
                }
            }
            return string.Empty;
        }
    }
}

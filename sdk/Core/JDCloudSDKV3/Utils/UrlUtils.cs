using System;
namespace JDCloudSDK.Core.Utils
{
    /// <summary>
    /// the url tools
    /// </summary>
    public class UrlUtils
    {
        /// <summary>
        /// Gets the URL version.
        /// </summary>
        /// <returns>The URL version.</returns>
        /// <param name="requestPath">Request path.</param>
        public static string GetUrlVersion(string requestPath) {
            var version = "v1";
            var pathArray = requestPath.Split('/');
            if(pathArray!=null && pathArray.Length > 0) {
                var versionString = pathArray[0];
                if (versionString.StartsWith("v", StringComparison.CurrentCulture)) {
                    return versionString;
                }
            }
            return version;

        }


    }
}

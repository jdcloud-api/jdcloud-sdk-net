using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;
using System.Linq;
using JDCloudSDK.Core.Utils;
using JDCloudSDK.Core.Auth.Sign;

namespace DotNetCoreTest
{
    public class CommonTest
    {
        private readonly ITestOutputHelper _output;
        public CommonTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void QueryStringTest() {
            var queryString = @"?aa=aa&aa%3Daa=&aa=aa%3D&aa=&aa=aaa&aaa=aaa&aaa=aa&aaa=a&ab=aa&ab=aa&cc=&cc=&bb=aa&bb=";

            var result = JDCloudSignerV3.ProcessQueryString(queryString);

            _output.WriteLine(result);
        }

        [Fact]
        public void URITest() {
            // /v1/regions/cn-north-1/instances/%20/%60!@
            var path = "/v1/regions/cn-north-1/instances/ /`!@#$%^&*()=+/0123456789/[]\\;',<>?:\"{}|///abcdefghijklmnopqrstuvwxyz/ABCDEFGHIJKLMNOPQRSTUVWXYZ/-_.~:GET";
            var host = @"http://apigw-internal-dev.cn-north-1.jcloudcs.com:8000";
            if (!path.StartsWith("/", StringComparison.CurrentCulture)) {
                path = "/" + path;
            }

            path = path.Replace("+", " ");
            var pathArray = path.Split('/');
            var pathDecodeArray = pathArray.Select(p => JDCloudSignV3Util.UnescapeDataStringRfc3986(p)).ToList();
            var pathList = pathDecodeArray.Select(p => JDCloudSignV3Util.EscapeUriDataStringRfc3986(p)).ToList();
            pathList.RemoveAll(p => p.Equals(string.Empty));
            path = string.Join("/", pathList.ToArray());
            if (!path.StartsWith("/"))
            {
                path = $"/{path}";
            }
            _output.WriteLine(path);

        }
    }
}

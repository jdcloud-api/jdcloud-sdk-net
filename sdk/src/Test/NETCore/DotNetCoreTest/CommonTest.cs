using System;
using Xunit;
using Xunit.Abstractions;

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
        public void URITest() {
            var path = "/v1/regions/cn-north-1/instances/ /`!@#$%^&*()=+/0123456789/[]\\;',<>?:\"{ }|/ abcdefghijklmnopqrstuvwxyz / ABCDEFGHIJKLMNOPQRSTUVWXYZ / -_.~:GET";
            var host = @"http://apigw-internal-dev.cn-north-1.jcloudcs.com:8000";
            if (!path.StartsWith("/", StringComparison.CurrentCulture)) {
                path = "/" + path;
            }

            var url = host + path;

            Uri uri = new Uri(url);

            _output.WriteLine(uri.AbsolutePath);

        }
    }
}

using JDCloudSDK.Core.Extensions;
using System;
using System.Net.Http;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        private readonly ITestOutputHelper _output;
        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }


        [Fact]
        public void Test1()
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = HttpMethod.Get;
            httpRequestMessage.RequestUri = new Uri("http://xohk7ybhwien.cn-north-1.jdcloud-api.net:8000/todo/api/v1/tasks/getAllOrUniqueTask");
            HttpClientWrapper httpClientWrapper = httpClient.DoSign(new JDCloudSDK.Core.Auth.Credentials("8EC5C825FB08E97F3E09043DA0557861", "A314732B21F8633D32D473859F502C20"), "xohk7ybhwien");
            HttpResponseMessage httpResponseMessage = httpClientWrapper.GetAsync("http://xohk7ybhwien.cn-north-1.jdcloud-api.net:8000/todo/api/v1/tasks/getAllOrUniqueTask").Result;
            if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = httpResponseMessage.Content.ReadAsStringAsync().Result;
                _output.WriteLine(result);
            }
        }
    }
}

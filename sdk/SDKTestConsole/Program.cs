using JDCloudSDK.Core.Extensions;
using System;
using System.Net.Http;

namespace SDKTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            HttpClientWrapper httpClientWrapper = httpClient.DoSign(new JDCloudSDK.Core.Auth.Credentials("8EC5C825FB08E97F3E09043DA0557861", "A314732B21F8633D32D473859F502C20"), "xohk7ybhwien");
            HttpResponseMessage httpResponseMessage = httpClientWrapper.GetAsync("http://xohk7ybhwien.cn-north-1.jdcloud-api.net:8000/todo/api/v1/tasks/getAllOrUniqueTask").Result;
            if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = httpResponseMessage.Content.ReadAsStringAsync().Result;
                Console.WriteLine(result);
            }
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}

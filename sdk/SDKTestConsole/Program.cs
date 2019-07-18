using JDCloudSDK.Core.Auth;
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
            HttpClientWrapper httpClientWrapper = httpClient.DoSign(new JDCloudSDK.Core.Auth.Credentials("8EC5C825FB08E97F3E09043DA0557861", "A314732B21F8633D32D473859F502C20"), "xohk7ybhwien", null, new DateTime(2019, 07, 18, 10, 16, 0));
            HttpResponseMessage httpResponseMessage = httpClientWrapper.GetAsync("http://xohk7ybhwien.cn-north-1.jdcloud-api.net:8000/todo/api/v1/tasks/getAllOrUniqueTask").Result;
            if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = httpResponseMessage.Content.ReadAsStringAsync().Result;
                Console.WriteLine(result);
            }
            //Credentials credentials = new Credentials("0E91C3765B78CBD71715F9BF24997AF3", "AF7B13C8010F50F03A52C01458714701");
            //HttpResponseMessage httpResponseMessage = httpClient.DoSign(credentials, "vm", null, new DateTime(2019, 7, 18, 2, 22, 22)).GetAsync("http://apigw-internal.cn-north-1.jcloudcs.com/v1/regions/cn-north-1/instances").Result;
            //if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    var result = httpResponseMessage.Content.ReadAsStringAsync().Result;
            //    Console.WriteLine(result);
            //}
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}

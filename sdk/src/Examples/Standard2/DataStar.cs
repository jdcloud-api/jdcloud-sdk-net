using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Datastar.Apis;
using JDCloudSDK.Datastar.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{
    public class DataStarTest
    {
        private readonly ITestOutputHelper _output;
        public DataStarTest(ITestOutputHelper output)
        {
            _output = output;
        }


        [Fact]
        public void TestStopInstance()
        {
            string accessKeyId = "your jdcloud ak";
            string secretAccessKey = "you jdcloud sk";
            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);

            HttpRequestConfig httpRequestConfig = new HttpRequestConfig();
            DatastarClient dataClient = new DatastarClient.DefaultBuilder()
                .CredentialsProvider(credentialsProvider)
                .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTPS, 10))
                .Build();

            //3. 设置请求参数
            //GetLargeScreenDataRequest
            GetLargeScreenDataRequest lsRequest = new GetLargeScreenDataRequest();
            lsRequest.RegionId = "cn-south-1";
            lsRequest.EndDate = "2019-02-18";
            lsRequest.StartDate = "2019-02-10";
            lsRequest.Version = "v1";
            lsRequest.Region = "福清县";
            lsRequest.Industry = "食品";
            lsRequest.FirstIndex = "食品";
            lsRequest.SecondIndex = "价格指数";

            //4. 执行请求
            var response1 = dataClient.GetLargeScreenData(lsRequest).Result;
            Console.WriteLine(JsonConvert.SerializeObject(response1));
        }
    }
}

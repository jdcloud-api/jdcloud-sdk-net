using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Nc.Apis;
using JDCloudSDK.Nc.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{

    public  class NCTest
    {

        private readonly ITestOutputHelper _output;
        public NCTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestDescribeQuota()
        {
            DescribeQuotaRequest request = new DescribeQuotaRequest();
            request.RegionId = "cn-north-1";
            request.ResourceType = "container";
            NcClient ncClient = GetNcClient();
            ncClient.SetCustomHeader("x-jdcloud-pin", "jcloud_00");
            ncClient.SetCustomHeader("x-jdcloud-erp", "DemoUser");
            var result = ncClient.DescribeQuota(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

        [Fact]
        public void TestDescribeContainers()
        {
            NcClient ncClient = GetNcClient();
            DescribeContainersRequest request = new DescribeContainersRequest();
            request.RegionId = "cn-north-1";
            //request.PageNumber = 1;
            //request.PageSize = 100;
            ncClient.SetCustomHeader("x-jdcloud-pin", "jcloud_00");
            ncClient.SetCustomHeader("x-jdcloud-erp", "DemoUser");

            var result = ncClient.DescribeContainers(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

  




        public NcClient GetNcClient()
        {
            //1. 设置accessKey和secretKey
            string accessKeyId = "";

            string secretAccessKey = "";

            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);
            //2. 创建XXXClient
            NcClient ncClient = new NcClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))

                    .Build();
            return ncClient;
        }
    }
}

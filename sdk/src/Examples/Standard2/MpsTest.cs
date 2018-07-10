using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Mps.Apis;
using JDCloudSDK.Mps.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{
    public class MpsTest
    {
        private readonly ITestOutputHelper _output;
        public MpsTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestListtThumbnailTask()
        {
            MpsClient mpsClient = GetMpsClient();
            ListThumbnailTaskRequest request = new ListThumbnailTaskRequest();
            request.RegionId = "cn-north-1";
            request.Status = "SUCCESS";
            var result =  mpsClient.ListThumbnailTask(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

        public MpsClient GetMpsClient()
        {
            //1. 设置accessKey和secretKey

            string accessKeyId = "";
            string secretAccessKey = "";

            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);

            //2. 创建XXXClient
            MpsClient mpsClient = new MpsClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))
                    .Build();
            return mpsClient;
        }
    }
}

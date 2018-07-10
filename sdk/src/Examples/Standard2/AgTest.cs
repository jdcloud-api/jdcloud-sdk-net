using JDCloudSDK.Ag.Apis;
using JDCloudSDK.Ag.Client;
using JDCloudSDK.Common.Model;
using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{
    public class AgTest
    {

        private readonly ITestOutputHelper _output;
        public AgTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestCreateAg()
        {
            var agClient = GetAgClient();
            CreateAgRequest request = new CreateAgRequest();
            request.RegionId = "cn-north-1";
            request.Azs = new List<string>() { "cn-north-1a" } ;
            request.AgName = "testDOTNETSDK1";
            request.AgType = "compute";
            request.InstanceTemplateId =  "it-vmw5gzskeu";
            request.Description = "test DOTNET sdK";
            CreateAgResponse response = agClient.CreateAg(request).Result; 
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        /// <summary>
        ///  TODO 此接口没有进行测试
        /// </summary>
        [Fact]
        public void TestDescribeAg()
        {
            var agClient = GetAgClient();
            DescribeAgRequest request = new DescribeAgRequest();
            request.RegionId = "cn-north-1";
            request.AgId = "";
            var response = agClient.DescribeAg(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        /// <summary>
        ///  TODO 此接口没有进行测试
        /// </summary>
        [Fact]
        public void TestDeleteAg()
        {
            var agClient = GetAgClient();
            DeleteAgRequest request = new DeleteAgRequest();
            request.RegionId = "cn-north-1";
            request.AgId = "";
            var response = agClient.DeleteAg(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));

        }

        /// <summary>
        ///  TODO 此接口没有进行测试
        /// </summary>
        [Fact]
        public void TestUpdateAg()
        {
            var agClient = GetAgClient();
            UpdateAgRequest request = new UpdateAgRequest();
            request.RegionId="cn-north-1";
            request.AgId="ag-fjw3xqwayl";
            request.Name = "sdk";
            request.Description = "sdk";

            var response = agClient.UpdateAg(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        /// <summary>
        ///  TODO 此接口没有进行测试
        /// </summary>
        [Fact]
        public void TestAbandonInstances()
        {
            var agClient = GetAgClient();
            AbandonInstancesRequest request = new AbandonInstancesRequest();
            request.RegionId="cn-north-1";
            request.AgId = "ag-fjw3xqwayl";
            request.InstanceIds = new List<string>() { "i-adfasdfasdfas" };
            var response = agClient.AbandonInstances(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        /// <summary>
        ///  TODO 此接口没有进行测试
        /// </summary>

        [Fact]
        public void TestSetInstanceTemplate()
        {
            var agClient = GetAgClient();
            SetInstanceTemplateRequest request = new SetInstanceTemplateRequest();
            request.RegionId = "cn-north-1";
            request.InstanceTemplateId = "it-vmw5gzskeu";
            request.AgId = "ag-fjw3xqwayl";
            var response = agClient.SetInstanceTemplate(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));

        }

        /// <summary>
        ///  TODO 此接口没有进行测试
        /// </summary>
        [Fact]
        public void TestStartAutoScaling()
        {
            var agClient = GetAgClient();
            StartAutoScalingRequest request = new StartAutoScalingRequest();
            request.RegionId = "cn-north-1";
            request.AgId = "ag-fjw3xqwayl";
            request.MaxSize =  10;
            request.MinSize = 0;
            request.TerminationStrategy = "OldestInstance";
            var response = agClient.StartAutoScaling(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));

        }

        [Fact]
        public void TestStopAutoScaling()
        {
            var agClient = GetAgClient();
            StopAutoScalingRequest request = new StopAutoScalingRequest();
            request.RegionId = "cn-north-1";
            request.AgId = "ag-fjw3xqwayl";
            var response = agClient.StopAutoScaling(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));

        }

        [Fact]
        public void TestDescribeQuotas()
        {
            var agClient = GetAgClient();
            DescribeQuotasRequest request = new DescribeQuotasRequest();
            request.RegionId = "cn-north-1";
            List<Filter> filters = new List<Filter>();

            Filter f1 = new Filter();
            f1.Name="resourceTypes";
            f1.Values= new List<string>() { "ag" };
            filters.Add(f1);
            request.Filters = filters;
            //4. 执行请求
            var response = agClient.DescribeQuotas(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Fact]
        public void TestModifyQuota()
        {
            var agClient = GetAgClient();
            ModifyQuotaRequest request = new ModifyQuotaRequest();
            request.RegionId = "cn-north-1";
            request.ResourceType = "ag";
            request.Limit = 15;
            ModifyQuotaResponse response = agClient.ModifyQuota(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));

        }
         

        public AgClient GetAgClient()
        {
            //1. 设置accessKey和secretKey

            string accessKeyId = "";
            string secretAccessKey = "";

            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);
            //2. 创建XXXClient
            AgClient diskClient = new AgClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))
                    .Build();
            return diskClient;
        }
    }
}

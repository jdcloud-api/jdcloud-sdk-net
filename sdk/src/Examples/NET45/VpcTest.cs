using System;
using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Vpc.Apis;
using JDCloudSDK.Vpc.Client;
using JDCloudSDK.Vpc.Model; 
using Newtonsoft.Json;
using NUnit.Framework;

namespace JDCloudSDK.Vpc.Test.NET45
{
    [TestFixture]
    public class VpcTest
    {
        [Test]
        public void TestVpcGetElasticIps()
        {
            VpcClient vpcClient = GetVpcClient();
            DescribeElasticIpsRequest request = new DescribeElasticIpsRequest();
            request.PageNumber = 1;
            request.PageSize = 100;
            request.RegionId = "cn-north-1";
            var result = vpcClient.DescribeElasticIps(request).Result;
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Test]
        public void TestVpcCreateElasticIps()
        {
            VpcClient vpcClient = GetVpcClient();
            CreateElasticIpsRequest request = new CreateElasticIpsRequest();
            ElasticIpSpec elasticIpSpec = new ElasticIpSpec();
            elasticIpSpec.BandwidthMbps = 2;
            elasticIpSpec.Provider = "bgp";
            request.ElasticIpSpec = elasticIpSpec;
            request.MaxCount = 1;
            request.RegionId = "cn-north-1";
            var result = vpcClient.CreateElasticIps(request).Result;
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }
     


        public VpcClient GetVpcClient()
        {
            //1. 设置accessKey和secretKey

            //线上  
            string accessKeyId = "";
            string secretAccessKey = "";
            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);
           //2. 创建XXXClient
            VpcClient vpcClient = new VpcClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))
                    .Build();
            return vpcClient;
        }
    }
}

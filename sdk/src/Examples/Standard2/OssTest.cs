using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Oss.Apis;
using JDCloudSDK.Oss.Client;
using Newtonsoft.Json;
using System;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{
    public class OssTest
    {

        private readonly ITestOutputHelper _output;
        public OssTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestListBuckets()
        {
            OssClient ossClient = GetOssClient();
            ListBucketsRequest request = new ListBucketsRequest();
            request.RegionId = "cn-north-1";
            var result = ossClient.ListBuckets(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestHeadBucket()
        {
            OssClient ossClient = GetOssClient();
            HeadBucketRequest request = new HeadBucketRequest();
            request.RegionId = "cn-north-1";
            request.Bucketname = "BIBO";
            var result = ossClient.HeadBucket(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestPutBucket()
        {
            OssClient ossClient = GetOssClient();
            PutBucketRequest putBucketRequest = new PutBucketRequest();
            putBucketRequest.RegionId = "cn-north-1";
            putBucketRequest.Bucketname = "DotNetTest";
            var result = ossClient.PutBucket(putBucketRequest).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));


        }

        [Fact]
        public void TestDeleteBucket()
        {
            OssClient ossClient = GetOssClient();
            DeleteBucketRequest deleteBucketRequest = new DeleteBucketRequest();
            deleteBucketRequest.RegionId = "cn-north-1";
            deleteBucketRequest.Bucketname = "DotNetTest";
            var result = ossClient.DeleteBucket(deleteBucketRequest).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }


        public OssClient GetOssClient()
        {
            //1. 设置accessKey和secretKey

            //线上  
            string accessKeyId = "";
            string secretAccessKey = "";
            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);
         
            //2. 创建XXXClient
            OssClient ossClient = new OssClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))
                  
                    .Build();
            return ossClient;
        }
    }
}

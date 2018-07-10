using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Redis.Apis;
using JDCloudSDK.Redis.Client;
using JDCloudSDK.Redis.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{
    public  class RedisTest
    {
        private readonly ITestOutputHelper _output;
        public RedisTest(ITestOutputHelper output)
        {
            _output = output;
        }

        /// <summary>
        /// "CacheInstanceId":"redis-tea5nycuyh","CacheInstanceName":"云网关部-redis-测试","CacheInstanceClass":"redis.m1.micro.basic","CacheInstanceMemoryMB":1024,"CacheInstancStatus":null,"CacheInstanceDescription":"","CreateTime":"2018-04-10T06:21:07Z","AzId":{"Master":"cn-north-1a","Slave":"cn-north-1a"},"VpcId":"vpc-97fysl2cyn","SubnetId":"subnet-ll47yy373i
        /// </summary>

        [Fact]
        public void TestDescribeCacheInstances()
        {
            var redisClient = GetRedisClient();
            DescribeCacheInstancesRequest request = new DescribeCacheInstancesRequest();
            request.RegionId = "cn-north-1";
            request.PageSize = 100;
            request.PageNumber = 1;

            var result = redisClient.DescribeCacheInstances(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeCacheInstance()
        {
            var redisClient = GetRedisClient();
            DescribeCacheInstanceRequest request = new DescribeCacheInstanceRequest();
            request.RegionId = "cn-north-1";
            request.CacheInstanceId = "redis-tea5nycuyh";
            var result = redisClient.DescribeCacheInstance(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestCreateCacheInstance()
        {
            var redisClient = GetRedisClient();
            CreateCacheInstanceRequest request = new CreateCacheInstanceRequest();
            request.RegionId = "cn-north-1";
            CacheInstanceSpec cacheInstanceSpec = new CacheInstanceSpec();
            AzIdSpec azIdSpec = new AzIdSpec();
            azIdSpec.Master = "cn-north-1a";
            azIdSpec.Slave = "cn-north-1a";
            cacheInstanceSpec.AzId = azIdSpec;
            cacheInstanceSpec.CacheInstanceClass = "redis.m1.micro.basic";
            cacheInstanceSpec.CacheInstanceDescription = "dotnetsdkredistest";
            cacheInstanceSpec.CacheInstanceName = "sdkredistest";
            cacheInstanceSpec.Password = "Qq123456";
            cacheInstanceSpec.SubnetId = "subnet-ll47yy373i";
            cacheInstanceSpec.VpcId = "vpc-97fysl2cyn";
            request.CacheInstance = cacheInstanceSpec;
            var result = redisClient.CreateCacheInstance(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

        [Fact]
        public void TestDeleteCacheInstance()
        {
            var redisClient = GetRedisClient();
            DeleteCacheInstanceRequest request = new DeleteCacheInstanceRequest();
            request.RegionId = "cn-north-1";
            request.CacheInstanceId = "";
            var result = redisClient.DeleteCacheInstance(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestModifyCacheInstanceAttribute()
        {
            var redisClient = GetRedisClient();
            ModifyCacheInstanceAttributeRequest request = new ModifyCacheInstanceAttributeRequest();
            request.CacheInstanceId = "";
            request.CacheInstanceName = "sdkTestName";
            request.RegionId = "cn-north-1";
            request.CacheInstanceDescription = "sdkTestDes";
            var result = redisClient.ModifyCacheInstanceAttribute(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestModifyCacheInstanceClass()
        {
            var redisClient = GetRedisClient();
            ModifyCacheInstanceClassRequest request = new ModifyCacheInstanceClassRequest();
            request.CacheInstanceId = "";
            request.RegionId = "cn-north-1";
            request.CacheInstanceClass = "redis.m1.small.basic";
            var result = redisClient.ModifyCacheInstanceClass(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

        [Fact]
        public void TestResetCacheInstancePassword()
        {
            var redisClient = GetRedisClient();
            ResetCacheInstancePasswordRequest request = new ResetCacheInstancePasswordRequest();
            request.CacheInstanceId = "";
            request.Password = "Qq123456";
            request.RegionId = "cn-north-1";
            var result = redisClient.ResetCacheInstancePassword(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeInstanceClass()
        {
            var redisClient = GetRedisClient();
            DescribeInstanceClassRequest request = new DescribeInstanceClassRequest();
            request.RegionId = "cn-north-1";
            var result = redisClient.DescribeInstanceClass(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

        [Fact]
        public void TestModifyInstanceClass()
        {
            var redisClient = GetRedisClient();
            ModifyInstanceClassRequest request = new ModifyInstanceClassRequest();
            request.RegionId = "cn-north-1";
            request.ActionType = 1;
            request.InstanceClass = "redis.m1.small.basic";
            var result = redisClient.ModifyInstanceClass(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeUserQuota()
        {
            var redisClient = GetRedisClient();
            DescribeUserQuotaRequest request = new DescribeUserQuotaRequest();
            request.RegionId = "cn-north-1";
            var result = redisClient.DescribeUserQuota(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestModifyUserQuota()
        {
            var redisClient = GetRedisClient();
            ModifyUserQuotaRequest request = new ModifyUserQuotaRequest();
            request.RegionId = "cn-north-1";
            request.Quota = 6;
            request.Used = 1;
            var result = redisClient.ModifyUserQuota(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        public RedisClient GetRedisClient()
        {
            //1. 设置accessKey和secretKey
            string accessKeyId = "";
            string secretAccessKey = "";

            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);
         
            //2. 创建XXXClient
            RedisClient redisClient = new RedisClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))

                    .Build();
            return redisClient;
        }
    }
}

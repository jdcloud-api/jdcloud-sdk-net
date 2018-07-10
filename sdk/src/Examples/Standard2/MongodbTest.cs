using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Mongodb.Apis;
using JDCloudSDK.Mongodb.Client;
using JDCloudSDK.Mongodb.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{
    public class MongodbTest
    {
        private readonly ITestOutputHelper _output;
        public MongodbTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestCreateInstance()
        { 
            MongodbClient mongodbClient = GetMongodbClient();
            CreateInstanceRequest request = new CreateInstanceRequest();
            request.RegionId = "cn-north-1";
            DBInstanceSpec dbInstanceSpec = new DBInstanceSpec();

            dbInstanceSpec.InstanceClass = "mongo.s1.small";
            dbInstanceSpec.InstanceStorageGB = 10;
            dbInstanceSpec.MultiAZ = false;
            dbInstanceSpec.AzId = new List<string>() { "cn-north-1a", "cn-north-1a", "cn-north-1a" };
            dbInstanceSpec.VpcId = "vpc-zo33sfjnbo";
            dbInstanceSpec.SubnetId = "subnet-j0yka3pkcu";
            dbInstanceSpec.Password = "Qq123456";
            dbInstanceSpec.InstanceName = "dotnetsdktest";
            request.InstanceSpec = dbInstanceSpec;
            var response = mongodbClient.CreateInstance(request);
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Fact]
        public void TestDescribeInstances()
        {
            //mongo-c2eirq2e84
            MongodbClient mongodbClient = GetMongodbClient();
            DescribeInstancesRequest request = new DescribeInstancesRequest();
            request.PageNumber = 1;
            request.PageSize = 100;
            request.RegionId = "cn-north-1";
            var response = mongodbClient.DescribeInstances(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Fact]
        public void TestDeleteInstance()
        {
            MongodbClient mongodbClient = GetMongodbClient();
            DeleteInstanceRequest request = new DeleteInstanceRequest();
            request.RegionId = "cn-north-1";
            request.InstanceId = "mongo-hfu1w2uhbc";
            var response = mongodbClient.DeleteInstance(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Fact]
        public void TestModifyInstanceSpec()
        {
            MongodbClient mongodbClient = GetMongodbClient();
            ModifyInstanceSpecRequest request = new ModifyInstanceSpecRequest();
            request.InstanceId = "mongo-hfu1w2uhbc";
            request.RegionId = "cn-north-1";
            request.InstanceStorageGB = 20; 
            request.InstanceClass = "mongo.s1.small";
            var response = mongodbClient.ModifyInstanceSpec(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Fact]
        public void TestModifyInstanceName()
        {
            MongodbClient mongodbClient = GetMongodbClient();
            ModifyInstanceNameRequest request = new ModifyInstanceNameRequest();
            request.InstanceId = "mongo-hfu1w2uhbc";
            request.InstanceName = "dotnetsdk test";
            request.RegionId = "cn-north-1";
            var response = mongodbClient.ModifyInstanceName(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Fact]
        public void TestResetPassword()
        {
            MongodbClient mongodbClient = GetMongodbClient();
            ResetPasswordRequest request = new ResetPasswordRequest();
            request.InstanceId = "mongo-hfu1w2uhbc";
            request.RegionId = "cn-north-1";
            request.AccountPassword = "Qq123456";
            var response = mongodbClient.ResetPassword(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Fact]
        public void TestCreateBackup()
        {
            MongodbClient mongodbClient = GetMongodbClient();
            CreateBackupRequest request = new CreateBackupRequest();
            request.InstanceId = "mongo-hfu1w2uhbc";
            request.RegionId = "cn-north-1";
            request.BackupName = "dotnetsdktestbackup";
            var response = mongodbClient.CreateBackup(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Fact]
        public void TestRestoreInstance()
        {
            MongodbClient mongodbClient = GetMongodbClient();
            RestoreInstanceRequest request = new RestoreInstanceRequest();
            request.RegionId = "cn-north-1";
            request.InstanceId = "mongo-hfu1w2uhbc";
            request.BackupId = "mongo-hfu1w2uhbc@115306868213070";
            var response = mongodbClient.RestoreInstance(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }


    
        [Fact]
        public void TestDeleteBackup()
        {
            MongodbClient mongodbClient = GetMongodbClient();
            DeleteBackupRequest request = new DeleteBackupRequest();
            request.RegionId = "cn-north-1";
            request.BackupId = "mongo-hfu1w2uhbc@115306868213070";
            var response = mongodbClient.DeleteBackup(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }


        public MongodbClient GetMongodbClient()
        {
            //1. 设置accessKey和secretKey
 
            string accessKeyId = "";
            string secretAccessKey = "";

            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);

            //2. 创建XXXClient
            MongodbClient mongodbClient = new MongodbClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))
                    .Build();
            return mongodbClient;
        }
    }


}

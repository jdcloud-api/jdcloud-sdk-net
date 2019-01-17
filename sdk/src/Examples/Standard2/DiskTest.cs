using JDCloudSDK.Common.Model;
using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Disk.Apis;
using JDCloudSDK.Disk.Client;
using JDCloudSDK.Disk.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{
    
    public class DiskTest
    {
        private readonly ITestOutputHelper _output;
        public DiskTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestDescribeDisk()
        {
            DiskClient diskClient = GetDiskClient();
            DescribeDiskRequest request = new DescribeDiskRequest();
            request.RegionId = "cn-north-1";
            request.DiskId = "vol-bwxyeo32bv"; 
            var result = diskClient.DescribeDisk(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result)); 
        }

        [Fact]
        public void TestDescribeDisks() {
            DiskClient diskClient = GetDiskClient();
            DescribeDisksRequest request = new DescribeDisksRequest();

            request.RegionId = "cn-north-1";
            request.PageNumber = 1;
            request.PageSize = 100;
            Filter diskFilter = new Filter();
            diskFilter.Name = "status";
            List<string> val = new List<string>();
            val.Add("available");
            diskFilter.Values = val;
            request.Filters = new List<Filter>();
            request.Filters.Add(diskFilter);
            var result = diskClient.DescribeDisks(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result)); 
        }

        [Fact]
        public void TestModifyDiskAttribute()
        {
            DiskClient diskClient = GetDiskClient();
            ModifyDiskAttributeRequest request = new ModifyDiskAttributeRequest();
            request.RegionId = "cn-north-1";
            request.DiskId = "vol-bwxyeo32bv";
            request.Description = "dotnet test";
            var result = diskClient.ModifyDiskAttribute(request);
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestCreateSnapshot()
        {
            DiskClient diskClient = GetDiskClient();
            CreateSnapshotRequest request = new CreateSnapshotRequest();
            request.RegionId = "cn-north-1";
            request.ClientToken = Guid.NewGuid().ToString().Replace("-", "");
            SnapshotSpec snapshotSpec = new SnapshotSpec();
            snapshotSpec.DiskId = "vol-s7s7vakg2k";
            snapshotSpec.Description = "dotnet sdk test";
            snapshotSpec.Name = "dotnet sdk test"; 
            request.SnapshotSpec = snapshotSpec;
            var result = diskClient.CreateSnapshot(request);
            _output.WriteLine(JsonConvert.SerializeObject(result)); 
        }

        [Fact]
        public void TestDescribeSnapshot()
        {
            DiskClient diskClient = GetDiskClient();
            DescribeSnapshotRequest request = new DescribeSnapshotRequest();
            request.RegionId = "cn-north-1";
            request.SnapshotId = "snapshot-d66rlhywi3";
            var result = diskClient.DescribeSnapshot(request);
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

        [Fact]
        public void TestDescribeSnapshots()
        {
            DiskClient diskClient = GetDiskClient();
            DescribeSnapshotsRequest request = new DescribeSnapshotsRequest();
            request.RegionId = "cn-north-1";
            request.PageSize = 100;
            request.PageNumber = 1;

            Filter snpFilter = new Filter();
            snpFilter.Name ="diskId";
            List<string> val1 = new List<string>();
            val1.Add("vol-bwxyeo32bv");
            snpFilter.Values =val1;
            //Filter stateFilter = new Filter();
            //stateFilter.Name = "status";
            //List<String> val2 = new List<String>();
            //val2.Add("available");
            //stateFilter.Values = val2;
            request.Filters = new List<Filter>();
            request.Filters.Add(snpFilter);
           // request.Filters.Add(stateFilter);
            var result = diskClient.DescribeSnapshots(request);
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

        [Fact]
        public void TestModifySnapshotAttribute()
        {
            DiskClient diskClient = GetDiskClient();
            ModifySnpAttributeRequest request = new ModifySnpAttributeRequest();

            request.RegionId = "cn-north-1";
            request.SnapshotId = "snapshot-d66rlhywi3";
            request.Name = "dotnet sdk modify test";
           // var result = diskClient.ModifySnpAttribute(request);
           // _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDeleteSnapshot()
        {
            DiskClient diskClient = GetDiskClient();
            DeleteSnapshotRequest request = new DeleteSnapshotRequest();

            request.RegionId = "cn-north-1";
            request.SnapshotId = "snapshot-sq1i919o98"; 
            var result = diskClient.DeleteSnapshot(request);
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestRestoreDisk()
        {
            DiskClient diskClient = GetDiskClient();
            RestoreDiskRequest request = new RestoreDiskRequest();
            request.RegionId = "cn-north-1";
            request.SnapshotId = "snapshot-sq1i919o98";
            request.DiskId = "vol-bwxyeo32bv";
            var result = diskClient.RestoreDisk(request);
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }
         
        public DiskClient GetDiskClient()
        {
            //1. 设置accessKey和secretKey

            string accessKeyId = "";
            string secretAccessKey = "";

            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);
            //2. 创建XXXClient
            DiskClient diskClient = new DiskClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))
                //     .Environment(env)
                    .Build();
            return diskClient;
        }
    }


}

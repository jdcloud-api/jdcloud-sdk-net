using JDCloudSDK.Charge.Model;
using JDCloudSDK.Common.Model;
using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Disk.Model;
using JDCloudSDK.Vm.Apis;
using JDCloudSDK.Vm.Client;
using JDCloudSDK.Vm.Model;
using JDCloudSDK.Vpc.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{
    public class VMTest
    {
        private readonly ITestOutputHelper _output;
        public VMTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestCreateInstance()
        {
            InstanceSpec instanceSpec = new InstanceSpec();
            instanceSpec.Az="cn-north-1a";
            instanceSpec.InstanceType="g.s1.micro";
            instanceSpec.ImageId= "bba85cab-dfdc-4359-9218-7a2de429dd80";
            instanceSpec.Name= "dotnet-sdk-test";
            instanceSpec.Description="dotnet-sdk";

            // 主网卡
            NetworkInterfaceSpec networkInterfaceSpec = new NetworkInterfaceSpec();
            networkInterfaceSpec.SubnetId= "subnet-j0yka3pkcu";
            networkInterfaceSpec.Az="cn-north-1a";
            InstanceNetworkInterfaceAttachmentSpec instanceNetworkInterfaceAttachmentSpec = new InstanceNetworkInterfaceAttachmentSpec();
            instanceNetworkInterfaceAttachmentSpec.NetworkInterface=networkInterfaceSpec;
            instanceSpec.PrimaryNetworkInterface=instanceNetworkInterfaceAttachmentSpec;

            // 系统盘
            InstanceDiskAttachmentSpec systemDisk = new InstanceDiskAttachmentSpec();
            systemDisk.DiskCategory="local";
            instanceSpec.SystemDisk=systemDisk;

            // 数据盘
            //InstanceDiskAttachmentSpec dataDisk1 = new InstanceDiskAttachmentSpec();
            //dataDisk1.DiskCategory="cloud";
            //dataDisk1.AutoDelete=true;
            //dataDisk1.CloudDiskSpec = new DiskSpec();
            //dataDisk1.CloudDiskSpec.Name = "sdk-test-disk1";
            //dataDisk1.CloudDiskSpec.DiskSizeGB =50 ;
            //dataDisk1.CloudDiskSpec.DiskType = "premium-hdd";

            //InstanceDiskAttachmentSpec dataDisk2 = new InstanceDiskAttachmentSpec();
            //dataDisk2.DiskCategory="cloud";
            //dataDisk2.AutoDelete =true;
            //dataDisk2.CloudDiskSpec = new DiskSpec();
            //dataDisk2.CloudDiskSpec.Name="sdk-test-disk2";
            //dataDisk2.CloudDiskSpec.DiskSizeGB = 40 ;
            //dataDisk2.CloudDiskSpec.DiskType="ssd";

            // List<InstanceDiskAttachmentSpec> dataDisks = new List<InstanceDiskAttachmentSpec>();
            //  dataDisks.Add(dataDisk1);
            // dataDisks.Add(dataDisk2);
            // instanceSpec.DataDisks = dataDisks;

            // 公网IP
            //ElasticIpSpec elasticIpSpec = new ElasticIpSpec();
            //elasticIpSpec.BandwidthMbps = 2;
           // elasticIpSpec.Provider = "BGP";
           // instanceSpec.ElasticIp = elasticIpSpec;

            // 计费方式
            ChargeSpec chargeSpec = new ChargeSpec();
            chargeSpec.ChargeMode = "postpaid_by_duration";

            // 请求创建
            CreateInstancesRequest request = new CreateInstancesRequest();
            request.RegionId = "cn-north-1";
            request.InstanceSpec = instanceSpec;
            request.MaxCount = 1;

            var vmClient = GetVmClient();
            CreateInstancesResponse response = vmClient.CreateInstances(request).Result;


            _output.WriteLine(JsonConvert.SerializeObject(response));
           // Console.WriteLine();

        }

        [Fact]
        public void TestStopInstance()
        {
            var vmClient = GetVmClient();
            StopInstanceRequest request = new StopInstanceRequest();
            request.RegionId="cn-north-1";
            request.InstanceId = "i-ifz5os5gkj";
           // request.RegionId="cn-north-1";
           // request.InstanceId="i-2a1v2rtlrq";
            //i-ifz5os5gkj i-zjjyo8hz89
            StopInstanceResponse response = vmClient.StopInstance(request).Result;
            //  System.out.println(new Gson().toJson(response));
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Fact]
        public void TestDeleteInstance()
        {
            var vmClient = GetVmClient();
            DeleteInstanceRequest request = new DeleteInstanceRequest();
            request.RegionId = "cn-north-1";
            request.InstanceId = "i-ifz5os5gkj";
            DeleteInstanceResponse  response= vmClient.DeleteInstance(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Fact]
        public void TestDescriptionInstances()
        {
             var vmClient = GetVmClient();
            
          //  var vmClient = new VmClient(credentialsProvider,new HttpRequestConfig(Protocol.HTTP,10));
            DescribeInstancesRequest describeInstancesRequest = new DescribeInstancesRequest();
            describeInstancesRequest.RegionId = "cn-north-1";
            describeInstancesRequest.PageSize = 20;
            describeInstancesRequest.PageNumber = 1;
            List<Filter> filters = new List<Filter>();

            Filter filter = new Filter();
            filter.Name = "name";
            List<string> filterValues = new List<string>();
            filterValues.Add("河北新明2");
            filter.Values = filterValues;
            filters.Add(filter);
            describeInstancesRequest.Filters = filters;
            var response = vmClient.DescribeInstances(describeInstancesRequest).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response.HttpResponse.Header));
            _output.WriteLine("=====================================================");
            _output.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Fact]
        public void TestDescriptionInstance()
        {
            DescribeInstanceRequest request = new DescribeInstanceRequest();
            request.RegionId = "cn-north-1";
            request.InstanceId = "i-zjjyo8hz89";
            var vmClient = GetVmClient();
            var response = vmClient.DescribeInstance(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(response));
        } 


        public VmClient GetVmClient()
        {
            //1. 设置accessKey和secretKey
            string accessKeyId = "0E91C3765B78CBD71715F9BF24997AF3";
            string secretAccessKey = "AF7B13C8010F50F03A52C01458714701";
            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);
            SDKEnvironment sDKEnvironment = new SDKEnvironment();
            sDKEnvironment.Endpoint = "apigw-internal.cn-north-1.jcloudcs.com";
            //2. 创建XXXClient
            VmClient vmClient = new VmClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))
                    .Environment(sDKEnvironment)
                    .Build();
            return vmClient;
        }
    }
}

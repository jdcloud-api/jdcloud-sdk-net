
using JDCloudSDK.Charge.Model;
using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Disk.Model;
using JDCloudSDK.Vm.Apis;
using JDCloudSDK.Vm.Client;
using JDCloudSDK.Vm.Model;
using JDCloudSDK.Vpc.Model;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDCloudSDK.Test.NET40
{
    [TestFixture]
    public class VmTest
    {
        [Test]
        public void TestCreateInstance()
        {
            InstanceSpec instanceSpec = new InstanceSpec();
            instanceSpec.Az = "cn-north-1a";
            instanceSpec.InstanceType = "g.s1.micro";
            instanceSpec.ImageId = "98d44a0f-88c1-451a-8971-f1f769073b6c";
            instanceSpec.Name = "dotnet-sdk-test";
            instanceSpec.Description = "dotnet-sdk";

            // 主网卡
            NetworkInterfaceSpec networkInterfaceSpec = new NetworkInterfaceSpec();
            networkInterfaceSpec.SubnetId = "subnet-j0yka3pkcu";
            networkInterfaceSpec.Az = "cn-north-1a";
            InstanceNetworkInterfaceAttachmentSpec instanceNetworkInterfaceAttachmentSpec = new InstanceNetworkInterfaceAttachmentSpec();
            instanceNetworkInterfaceAttachmentSpec.NetworkInterface = networkInterfaceSpec;
            instanceSpec.PrimaryNetworkInterface = instanceNetworkInterfaceAttachmentSpec;

            // 系统盘
            InstanceDiskAttachmentSpec systemDisk = new InstanceDiskAttachmentSpec();
            systemDisk.DiskCategory = "local";
            instanceSpec.SystemDisk = systemDisk;

            // 数据盘
            InstanceDiskAttachmentSpec dataDisk1 = new InstanceDiskAttachmentSpec();
            dataDisk1.DiskCategory = "cloud";
            dataDisk1.AutoDelete = true;
            dataDisk1.CloudDiskSpec = new DiskSpec();
            dataDisk1.CloudDiskSpec.Name = "sdk-test-disk1";
            dataDisk1.CloudDiskSpec.DiskSizeGB = 50;
            dataDisk1.CloudDiskSpec.DiskType = "premium-hdd";

            InstanceDiskAttachmentSpec dataDisk2 = new InstanceDiskAttachmentSpec();
            dataDisk2.DiskCategory = "cloud";
            dataDisk2.AutoDelete = true;
            dataDisk2.CloudDiskSpec = new DiskSpec();
            dataDisk2.CloudDiskSpec.Name = "sdk-test-disk2";
            dataDisk2.CloudDiskSpec.DiskSizeGB = 40;
            dataDisk2.CloudDiskSpec.DiskType = "ssd";

            List<InstanceDiskAttachmentSpec> dataDisks = new List<InstanceDiskAttachmentSpec>();
            dataDisks.Add(dataDisk1);
            dataDisks.Add(dataDisk2);
            instanceSpec.DataDisks = dataDisks;

            // 公网IP
            ElasticIpSpec elasticIpSpec = new ElasticIpSpec();
            elasticIpSpec.BandwidthMbps = 2;
            elasticIpSpec.Provider = "BGP";
            instanceSpec.ElasticIp = elasticIpSpec;

            // 计费方式
            ChargeSpec chargeSpec = new ChargeSpec();
            chargeSpec.ChargeMode = "postpaid_by_duration";

            // 请求创建
            CreateInstancesRequest request = new CreateInstancesRequest();
            request.RegionId = "cn-north-1";
            request.InstanceSpec = instanceSpec;
            request.MaxCount = 1;

            var vmClient = GetVmClient();
            CreateInstancesResponse response = vmClient.CreateInstances(request);


            Console.WriteLine(JsonConvert.SerializeObject(response));
            // Console.WriteLine();
        }

        [Test]
        public void TestStopInstance()
        {
            var vmClient = GetVmClient();
            StopInstanceRequest request = new StopInstanceRequest();
            request.RegionId = "cn-north-1";
            request.InstanceId = "i-zjjyo8hz89";
            // request.RegionId="cn-north-1";
            // request.InstanceId="i-2a1v2rtlrq";
            //i-ifz5os5gkj i-zjjyo8hz89
            StopInstanceResponse response = vmClient.StopInstance(request);
            //  System.out.println(new Gson().toJson(response));
            Console.WriteLine(JsonConvert.SerializeObject(response));
        }

        [Test]
        public void TestDeleteInstance()
        {
            var vmClient = GetVmClient();
            DeleteInstanceRequest request = new DeleteInstanceRequest();
            request.RegionId = "cn-north-1";
            request.InstanceId = "i-zjjyo8hz89";
            DeleteInstanceResponse response = vmClient.DeleteInstance(request);
            Console.WriteLine(JsonConvert.SerializeObject(response));
        }




        public VmClient GetVmClient()
        {
            //1. 设置accessKey和secretKey

            string accessKeyId = "";
            string secretAccessKey = "";

            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);
            //2. 创建XXXClient
            VmClient vmClient = new VmClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))
                    .Build();
            return vmClient;
        }
    }
}

using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Vpc.Apis;
using JDCloudSDK.Vpc.Client;
using JDCloudSDK.Vpc.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{
    public class VpcTest
    {

 

        private readonly ITestOutputHelper _output;
        public VpcTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestVpcGetElasticIps()
        {
            VpcClient vpcClient = GetVpcClient();

            DescribeElasticIpsRequest request = new DescribeElasticIpsRequest();

            request.PageNumber = 1;
            request.PageSize = 100;
            request.RegionId = "cn-north-1";
            var result = vpcClient.DescribeElasticIps(request).Result;

            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestVpcGetElasticIp()
        {
            VpcClient vpcClient = GetVpcClient();
            DescribeElasticIpRequest request = new DescribeElasticIpRequest();

            request.ElasticIpId = "fip-thkwn73kai";
            request.RegionId = "cn-north-1";
            var result = vpcClient.DescribeElasticIp(request).Result;

            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        //fip-by7n8lo360
        [Fact]
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
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestVpcDeleteElasticIp()
        {
            VpcClient vpcClient = GetVpcClient();
            DeleteElasticIpRequest request = new DeleteElasticIpRequest();
            request.ElasticIpId = "fip-by7n8lo360";
            request.RegionId = "cn-north-1";
            var result = vpcClient.DeleteElasticIp(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeNetworkInterfaces()
        {
            VpcClient vpcClient = GetVpcClient();
            DescribeNetworkInterfacesRequest request = new DescribeNetworkInterfacesRequest();
            request.PageSize = 100;
            request.PageNumber = 1;
            request.RegionId = "cn-north-1";
            var result = vpcClient.DescribeNetworkInterfaces(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeNetworkInterface()
        {
            VpcClient vpcClient = GetVpcClient();
            DescribeNetworkInterfaceRequest request = new DescribeNetworkInterfaceRequest();
            request.RegionId = "cn-north-1";
            request.NetworkInterfaceId = "port-ovvw8hxuwe";
            var result = vpcClient.DescribeNetworkInterface(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestAssociateElasticIp()
        {
            VpcClient vpcClient = GetVpcClient();
            AssociateElasticIpRequest request = new AssociateElasticIpRequest();
            request.RegionId = "cn-north-1";
            request.NetworkInterfaceId = "port-ovvw8hxuwe";
            request.ElasticIpId = "fip-thkwn73kai";
            // request.PrivateIpAddress = "10.100.0.18";
            var result = vpcClient.AssociateElasticIp(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDisassociateElasticIp()
        {
            VpcClient vpcClient = GetVpcClient();
            DisassociateElasticIpRequest request = new DisassociateElasticIpRequest();
            // request.ElasticIpAddress = "";
            // request.ElasticIpId = "";
            request.NetworkInterfaceId = "port-ovvw8hxuwe";
            request.RegionId = "cn-north-1";
            var result = vpcClient.DisassociateElasticIp(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        /// <summary>
        /// 需要修改再次测试 与类型转换有关 需要修改为可赋值为null 的类型
        /// </summary>
        [Fact]
        public void TestAssignSecondaryIps()
        {
            VpcClient vpcClient = GetVpcClient();
            AssignSecondaryIpsRequest request = new AssignSecondaryIpsRequest();
            request.RegionId = "cn-north-1";
            request.NetworkInterfaceId = "port-ovvw8hxuwe";
            List<string> secondIpList = new List<string>();
            secondIpList.Add("10.100.0.19");
            // request.SecondaryIpCount = 1.0M;
            var result = vpcClient.AssignSecondaryIps(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestUnassignSecondaryIps()
        {
            VpcClient vpcClient = GetVpcClient();
            UnassignSecondaryIpsRequest request = new UnassignSecondaryIpsRequest();
            request.RegionId = "cn-north-1";
            request.NetworkInterfaceId = "port-ovvw8hxuwe";
            request.SecondaryIps = new List<string>();
            var result = vpcClient.UnassignSecondaryIps(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeSubnets()
        {
            VpcClient vpcClient = GetVpcClient();
            DescribeSubnetsRequest request = new DescribeSubnetsRequest();
            request.RegionId = "cn-north-1";
            request.PageSize = 100;
            request.PageNumber = 1;
            var result = vpcClient.DescribeSubnets(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeSubnet()
        {

            VpcClient vpcClient = GetVpcClient();
            DescribeSubnetRequest request = new DescribeSubnetRequest();
            request.RegionId = "cn-north-1";
            request.SubnetId = "subnet-j0yka3pkcu";
            var result = vpcClient.DescribeSubnet(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeNetworkSecurityGroups()
        {
            VpcClient vpcClient = GetVpcClient();
            DescribeNetworkSecurityGroupsRequest request = new DescribeNetworkSecurityGroupsRequest();
            request.RegionId = "cn-north-1";
            request.PageSize = 100;
            request.PageNumber = 1;
            var result = vpcClient.DescribeNetworkSecurityGroups(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeNetworkSecurityGroup()
        {
            VpcClient vpcClient = GetVpcClient();
            DescribeNetworkSecurityGroupRequest request = new DescribeNetworkSecurityGroupRequest();
            request.RegionId = "cn-north-1";
            request.NetworkSecurityGroupId = "sg-26dmxjolr9";
            var result = vpcClient.DescribeNetworkSecurityGroup(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeVpcPeerings()
        { //vpcpr-lz0dmu4dxc
            VpcClient vpcClient = GetVpcClient();
            DescribeVpcPeeringsRequest request = new DescribeVpcPeeringsRequest();
            request.RegionId = "cn-north-1";
            request.PageNumber = 1;
            request.PageSize = 100;
            var result = vpcClient.DescribeVpcPeerings(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeVpcPeering()
        {
            VpcClient vpcClient = GetVpcClient();
            DescribeVpcPeeringRequest request = new DescribeVpcPeeringRequest();
            request.RegionId = "cn-north-1";
            request.VpcPeeringId = "vpcpr-lz0dmu4dxc";
            var result = vpcClient.DescribeVpcPeering(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

        [Fact]
        public void TestModifyVpcPeering()
        {
            VpcClient vpcClient = GetVpcClient();
            ModifyVpcPeeringRequest request = new ModifyVpcPeeringRequest();
            request.RegionId = "cn-north-1";
            request.VpcPeeringName = "";
            request.VpcPeeringId = "";
              var result = vpcClient.ModifyVpcPeering(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestCreateVpcPeering()
        {
            VpcClient vpcClient = GetVpcClient();
            CreateVpcPeeringRequest request = new CreateVpcPeeringRequest();
            request.RegionId = "cn-north-1";
            request.VpcPeeringName = "";
            request.VpcId = "";
            request.RemoteVpcId = "";
            var result = vpcClient.CreateVpcPeering(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDeleteVpcPeering()
        {
            VpcClient vpcClient = GetVpcClient();
            DeleteVpcPeeringRequest request = new DeleteVpcPeeringRequest();
            request.RegionId = "cn-north-1";
            request.VpcPeeringId = "";
            var result = vpcClient.DeleteVpcPeering(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

        [Fact]
        public void TestDescribeVpcs()
        {
            //vpc-zo33sfjnbo
            VpcClient vpcClient = GetVpcClient();
            DescribeVpcsRequest request = new DescribeVpcsRequest();
            request.RegionId = "cn-north-1";
            request.PageNumber = 1;
            request.PageSize = 100;
            var result = vpcClient.DescribeVpcs(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }
        [Fact]
        public void TestDescribeVpc()
        {
            VpcClient vpcClient = GetVpcClient();
            DescribeVpcRequest request = new DescribeVpcRequest();
            request.RegionId = "cn-north-1";
            request.VpcId = "vpc-zo33sfjnbo";
            var result = vpcClient.DescribeVpc(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
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

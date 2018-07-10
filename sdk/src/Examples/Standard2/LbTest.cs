using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Lb.Apis;
using JDCloudSDK.Lb.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{
    public class LbTest
    {
        private readonly ITestOutputHelper _output;
        public LbTest(ITestOutputHelper output)
        {
            _output = output;
        }

        /// <summary>
        /// {"RequestId":"bcv4343g1vq99h5m5r3r1ju63ugki12p","Error":null,"Result":{"TargetGroups":[{"TargetGroupId":"tg-ko32wdz5ve","TargetGroupName":"云网关部-虚拟服务器组-测试","LoadBalancerId":"alb-7738gj85t4","LoadBalancerName":"云网关部-负载均衡-测试","Description":"","CreatedTime":"2018-04-09 20:04:08","Targets":[{"TargetId":"target-zvxe1op9xx","TargetGroupId":"tg-ko32wdz5ve","InstanceId":"i-7h7y82unx3","Port":10000.0,"Weight":100.0,"PrivateIpAddress":"192.168.200.16"}]}],"TotalCount":1.0}}
        /// </summary>
        [Fact]
        public void TestDescribeTargetGroups()
        {
            LbClient lbClient = GetLbClient();
            DescribeTargetGroupsRequest request = new DescribeTargetGroupsRequest();
            request.RegionId = "cn-north-1";
            request.PageSize = 100;
            request.PageNumber = 1;

            var result = lbClient.DescribeTargetGroups(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }


        /// <summary>
        /// 删除 注册的Target TargetIds 为必填项但是yaml 没有标记
        /// </summary>
        [Fact]
        public void TestDeRegisterTargets()
        {
            LbClient lbClient = GetLbClient();
            DeRegisterTargetsRequest request = new DeRegisterTargetsRequest();
            request.RegionId = "cn-north-1";
            request.TargetGroupId = "tg-ko32wdz5ve";
            request.TargetIds = new List<string>() { "target-zvxe1op9xx" };
            var result = lbClient.DeRegisterTargets(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

        /// <summary>
        /// {"RequestId":"bcv44rm86i1wp0n7uectibc7nm5t3cvq","Error":null,"Result":{"LoadBalancers":[{"LoadBalancerId":"alb-7738gj85t4","LoadBalancerName":"云网关部-负载均衡-测试","SubnetId":"subnet-t3qzibg6nb","VpcId":"vpc-97fysl2cyn","Type":"alb","State":{"Code":"ACTIVE","Reason":"Alb is active."},"Azs":["cn-north-1a"],"SecurityGroupIds":["sg-2d6mn5n9wu","sg-a03x2zp9ov","sg-f0ho7p95ai"],"PrivateIp":{"privateIpAddress":"192.168.0.4","ElasticIpId":"","ElasticIpAddress":""},"Charge":{"ChargeMode":"postpaid_by_duration","ChargeStatus":"normal","ChargeStartTime":"2018-04-09 19:53:52","ChargeExpiredTime":"0001-01-01 00:00:00","ChargeRetireTime":null},"Description":"","DeleteProtection":false,"CreatedTime":"2018-04-09 19:53:54"}],"TotalCount":1.0}}
        /// </summary>
        [Fact]
        public void TestDescribeLoadBalancers()
        {
            LbClient lbClient = GetLbClient();
            DescribeLoadBalancersRequest request = new DescribeLoadBalancersRequest();
            request.RegionId = "cn-north-1";
            request.PageSize = 100;
            request.PageNumber = 1;

            var result = lbClient.DescribeLoadBalancers(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

        [Fact]
        public void TestDescribeTargetGroup()
        {
            LbClient lbClient = GetLbClient();

            DescribeTargetGroupRequest request = new DescribeTargetGroupRequest();
            request.RegionId = "cn-north-1";
            request.TargetGroupId = "tg-ko32wdz5ve";
            var result = lbClient.DescribeTargetGroup(request).Result;
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }







        public LbClient GetLbClient()
        {
            //1. 设置accessKey和secretKey

            string accessKeyId = "";
            string secretAccessKey = "";
            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);
            //2. 创建XXXClient
            LbClient lbClient = new LbClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))
                    .Build();
            return lbClient;
        }
    }
}

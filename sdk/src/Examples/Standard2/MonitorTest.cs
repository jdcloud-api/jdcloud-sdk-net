using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Monitor.Apis;
using JDCloudSDK.Monitor.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace JDCloudSDK.Test.Standard2
{
    
    public class MonitorTest
    {

        private readonly ITestOutputHelper _output;
        public MonitorTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestDescribeMetrics()
        {
            MonitorClient monitorClient = GetMonitorClient();
            DescribeMetricsRequest request = new DescribeMetricsRequest();
            request.RegionId = "cn-north-1";
            request.ServiceCode = "vm";
            var result =    monitorClient.DescribeMetrics(request).Result;

            _output.WriteLine(JsonConvert.SerializeObject(result));

        }

        [Fact]
        public void TestMetricsData()
        {
            MonitorClient monitorClient = GetMonitorClient();
            DescribeMetricDataRequest request = new DescribeMetricDataRequest();
            request.RegionId = "cn-north-1";
            request.Metric = "cpu_util";
            request.ServiceCode = "vm";
            request.ResourceId = "i-21n50s7wb4";
            request.TimeInterval = "1h";

            var result = monitorClient.DescribeMetricData(request);
            _output.WriteLine(JsonConvert.SerializeObject(result));
        }

     




        public MonitorClient GetMonitorClient()
        {
            //1. 设置accessKey和secretKey

            string accessKeyId = "";
            string secretAccessKey = "";
            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);

            //2. 创建XXXClient
            MonitorClient monitorClient = new MonitorClient.DefaultBuilder()
                    .CredentialsProvider(credentialsProvider)
                    .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP, 50))
                    .Build();
            return monitorClient;
        }

    }
}

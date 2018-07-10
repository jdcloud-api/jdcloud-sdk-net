
# 简介

&emsp;&emsp;欢迎使用京东云开发者.NET工具套件（.NET SDK）。 使用京东云 .NET SDK，您无需复杂编程就可以访问京东云提供的各种服务。   
&emsp;&emsp;为了方便您理解SDK中的一些概念和参数的含义，使用SDK前建议您先查看OpenAPI使用入门。要了解每个API的具体参数和含义，请参考程序注释或参考[OpenAPI&SDK]((https://www.jdcloud.com/help/faq?act=3))下具体产品线的API文档。

# 环境准备

* 此项目使用visual studio 2017 开发，如果需要进行代码编辑、调试，推荐使用visual studio 2017 以上版本打开。

* 项目使用了`netstandard2.0` 框架为基本框架，因此需要安装dotnet core 2.0 SDK。

* 项目使用多目标框架编译，目前使用的是`net35`、`net40`、`net45`和`netstandard2.0`。因Http请求在`net45`和`netstandard2.0`版本调用工具类使用`HttpClient`，如果使用`.Net Framework 4.5` 需要引用框架包`System.Net.Http`。因`HttpClient`不支持`.Net Framework 3.5`且对`.NetFramework 4.0` 的异步支持不是很完善，所以在项目中使用了`HttpWebRequest`进行了替换。

* 如果需要使用其他版本的SDK，请在项目中增加编译版本，同时修改编译判断条件 ，具体编译目标框架编译条件信息参见[微软官网文档（Target frameworks页面）](https://docs.microsoft.com/en-us/dotnet/standard/frameworks)。
* 因项目使用了`Newtonsoft.Json` 作为Json 对象转换的工具包，因此也需要引用`Newtonsoft.Json`，请在使用的时候选择与您使用的框架对应的版本引用。

* 在开始调用京东云open API之前，需提前在京东云用户中心账户管理下的AccessKey管理页面申请accesskey和secretKey密钥对（简称AK/SK）。AK/SK信息请妥善保管，如果遗失可能会造成非法用户使用此信息操作您在云上的资源，给你造成数据和财产损失。

# linux 编译说明

* 在编译前需要安装dotnet core sdk 2.0 以上版本。具体安装方法请访问[dotnetcore官方网站](https://www.microsoft.com/net/learn/get-started/linux)

* 可以使用项目中的脚本 `linux-bulid.sh` 进行编译，在编译前需要在解决方案中移除 Examples 文件夹下的项目，然后在与 `JDCloudSDK.sln` 同级别的目录执行脚本，编译输出目录为 {当前用户目录}/jdcloud-dotnet-sdk/release 这个目录下面，需要的可以修改脚本进行变更。

# SDK使用方法

&emsp;&emsp;在您的项目中引用需要调用的相关模块的dll 与 JDCloudSDK.Core 的dll 文件，加上上面提到的环境依赖项即可使用。稍后会将nuget包上传到镜像仓库，可以使用包管理工具进行管理。

# 调用SDK

.NET SDK的调用主要分为4步：

    1. 设置accessKey和secretKey
    2. 创建Client
    3. 设置请求参数
    4. 执行请求得到响应
以下是查询单个云主机实例详情的调用示例

```csharp
using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using Newtonsoft.Json;
using System;
using JDCloudSDK.Vm.Model;
using JDCloudSDK.Vm.Apis;
using JDCloudSDK.Vm.Client;
namespace JDCloudSDK.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 设置accessKey和secretKey
            string accessKeyId = "{accessKey}";
            string secretAccessKey = "{secretKey}";
            CredentialsProvider credentialsProvider = new StaticCredentialsProvider(accessKeyId, secretAccessKey);
            //2. 创建XXXClient
            VmClient vmClient = new VmClient.DefaultBuilder()
                     .CredentialsProvider(credentialsProvider)
                     .HttpRequestConfig(new HttpRequestConfig(Protocol.HTTP,10))
                     .Build();

            //3. 设置请求参数
            DescribeInstanceRequest request = new DescribeInstanceRequest();
            request.RegionId="cn-north-1";
            request.InstanceId="i-c0se9uju";
            //4. 执行请求，返回结果
            var response = vmClient.DescribeInstance(request).Result;
            Console.WriteLine(JsonConvert.SerializeObject(response))
            Console.ReadLine();
        }
    }
}
```

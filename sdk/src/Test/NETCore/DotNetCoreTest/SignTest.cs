using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Auth.Sign;
using JDCloudSDK.Core.Model;
using JDCloudSDK.Core.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace DotNetCoreTest
{
    public class SignTest
    {

        private readonly ITestOutputHelper _output;
        public SignTest(ITestOutputHelper output)
        {
            _output = output;
        }
        [Fact]
        public void TestMapParamToQueryString(){
            Dictionary<string,string> paramDic = new Dictionary<string, string>();
 
            // paramMap.put("nullValue", "");
            // paramMap.put("", "nullKey");
            // paramMap.put("specialValue", "&&==&==&&=&=");
            // paramMap.put("&&==&==&&=&=", "specialKey");
            paramDic.Add("nullValue","");
            paramDic.Add("","nullKey");
            paramDic.Add("specialValue","&&==&==&&=&=");
            paramDic.Add("&&==&==&&=&=","specialKey");
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("?");
            foreach(var item in paramDic){
                stringBuilder.Append(Uri.EscapeDataString(item.Key)).Append("=").Append(Uri.EscapeDataString(item.Value)).Append("&");
            }

            _output.WriteLine(stringBuilder.ToString().TrimEnd('&'));


        } 
        [Fact]
        public void TestProcessQueryString(){

            string queryString = "? =blank&%20=blank&+= 2&%2b= 1&blank= &blank=+&blank=%20";
            string request= JDCloudSignerV3.ProcessQueryString(queryString);
            _output.WriteLine(request);
             _output.WriteLine("%20=%202&%20=blank&%20=blank&%2B=%201&blank=%20&blank=%20&blank=%20");
            Assert.Equal("%20=%202&%20=blank&%20=blank&%2B=%201&blank=%20&blank=%20&blank=%20",request);
        }


        [Fact]
        public void TestSignCase() {
            List<TestCaseModel> readCaseExcel = GetTestCase();

            if (readCaseExcel != null && readCaseExcel.Count > 0) {
                WriteJsonFile(readCaseExcel);
            }

            IJDCloudSigner jDCloudSigner = new JDCloudSignerV3();
            List<SignedRequestModel> signedRequestModels = new List<SignedRequestModel>();
            StringBuilder stringBuilder = new StringBuilder();
            int i = 0;
            foreach (var item in readCaseExcel) { 
                var result = jDCloudSigner.Sign(item.RequestModel, new Credentials("ak", "sk"));
                stringBuilder.Append(System.Environment.NewLine).
                    Append("-------------------------------------------------------")
                    .Append(System.Environment.NewLine)
                    .Append(item.CaseName).
                    Append(System.Environment.NewLine).
                    Append("-------------------------------------------------------").Append(System.Environment.NewLine);
                //signedRequestModels.Add(result);
                stringBuilder.Append("MC:").Append(System.Environment.NewLine).Append(result.CanonicalRequest).Append(System.Environment.NewLine)
                    .Append("SC:").Append(System.Environment.NewLine).Append(item.CanonicalRequest).Append(System.Environment.NewLine);
                
                stringBuilder.Append("MSH:").Append(System.Environment.NewLine).Append(result.SignedHeaders).Append(System.Environment.NewLine)
                   .Append("SSH:").Append(System.Environment.NewLine).Append(item.Authorization).Append(System.Environment.NewLine);
                stringBuilder.Append(System.Environment.NewLine).Append("StringToSign:").Append(" ").Append(System.Environment.NewLine)
                    .Append(result.StringToSign).Append(System.Environment.NewLine);
                if (result.SignedHeaders != item.Authorization)
                {
                    _output.WriteLine($"test case Authorization error, , case name is {item.CaseName}"); 
                }
                string filePath = Directory.GetCurrentDirectory() + "\\ TestCase.log";
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    byte[] data = System.Text.Encoding.UTF8.GetBytes(stringBuilder.ToString());
                    fs.Write(data, 0, data.Length);
                    //清空缓冲区、关闭流
                    fs.Flush();
                    fs.Close();
                }
                i++;
            }


        }

        public static List<TestCaseModel> GetTestCase()
        {
            //var aaa = "/`!@#$%^&*()=+/0123456789/[]\\;',<>?:\"{}|/abcdefghijklmnopqrstuvwxyz/ABCDEFGHIJKLMNOPQRSTUVWXYZ/-_.~"
            List<TestCaseModel> testCaseModels = new List<TestCaseModel>();
            using (FileStream fileStream = File.OpenRead("./TestCase.xlsx"))
            {
                XSSFWorkbook xSSFWorkbook = new XSSFWorkbook(fileStream);
                ISheet sheet = xSSFWorkbook.GetSheetAt(1);
                string ak = "ak";
                string sk = "sk";
                for (int j = 1; j < sheet.LastRowNum; j++)
                { 
                    IRow row = sheet.GetRow(j);
                    if (row != null)
                    {
                        RequestModel requestModel = new RequestModel();
                        //string host = "apigw-internal-dev.cn-north-1.jcloudcs.com";
                        var port = 8000;
                        requestModel.RequestPort = port;
                        
                        requestModel.RegionName = row.Cells[5].StringCellValue;
                        if (string.IsNullOrWhiteSpace(requestModel.RegionName)) {
                            break;
                        }
                        requestModel.ServiceName = row.Cells[6].StringCellValue;
                        string host = row.Cells[7].StringCellValue;
                        if (row.Cells[2].StringCellValue == "header的value包含多个值")
                        {
                            Console.WriteLine(row.Cells[2].StringCellValue);
                        }
                        string header = row.Cells[8].StringCellValue;
                        Dictionary<string, Object> headerDictionary =
                            JsonConvert.DeserializeObject<Dictionary<string, Object>>(header);
                        if (headerDictionary != null && headerDictionary.Count > 0)
                        {
                            foreach (var item in headerDictionary)
                            {
                                if (item.Value is string)
                                {
                                    requestModel.AddHeader(item.Key, item.Value.ToString());
                                }
                                else if (item.Value is List<string>) {
                                    foreach (var valueItem in (List<string>)item.Value) {
                                        requestModel.AddHeader(item.Key, valueItem);
                                    }
                                } else if (item.Value.GetType() == typeof(JArray)) {
                                    foreach (var valueItem in (JArray)item.Value)
                                    {
                                        requestModel.AddHeader(item.Key, valueItem.ToString());
                                    }
                                }
                                
                            }
                        }
                        string requestPath = row.Cells[9].StringCellValue;
                        requestModel.ResourcePath = requestPath;
                        string queryString = row.Cells[10].StringCellValue;
                        if (!string.IsNullOrWhiteSpace(queryString) && queryString != "空")
                        {
                            requestModel.QueryParameters = queryString;
                        }
                        if (!requestPath.StartsWith("/"))
                        {
                            requestPath = $"/{requestPath}";
                        }
                        if (queryString == "空")
                        {
                            queryString = string.Empty;
                        }
                        if (!string.IsNullOrWhiteSpace(queryString)&&!queryString.StartsWith("?"))
                        {
                            queryString = $"?{queryString}";
                        }
                        
                        string url = $"{host}{requestPath}{queryString}";
                        Uri uri = new Uri(url);
                        requestModel.Uri = uri;
                        requestModel.HttpMethod = row.Cells[4].StringCellValue;
                        TestCaseModel testCaseModel = new TestCaseModel();
                        testCaseModel.RequestModel = requestModel;
                        testCaseModel.CaseName = row.Cells[2].StringCellValue;
                        testCaseModel.CanonicalRequest = row.Cells[11].StringCellValue;
                       // testCaseModel.StringToSign = row.Cells[11].StringCellValue;
                        testCaseModel.Authorization = row.Cells[12].StringCellValue;
                        testCaseModels.Add(testCaseModel);

                    }
                }


            }
            return testCaseModels;

        }


        public static void WriteJsonFile(List<TestCaseModel> requestModels) {
            if (requestModels != null && requestModels.Count > 0) {
                string json = JsonConvert.SerializeObject(requestModels, Formatting.Indented, new JsonSerializerSettings { ContractResolver = new JDCloudCamelCasePropertyNamesContractResolver() });
                
                string filePath = Directory.GetCurrentDirectory() + "\\ TestCase.json";
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                   
                using (FileStream fs = new FileStream(filePath, FileMode.Create)) {
                    byte[] data = System.Text.Encoding.UTF8.GetBytes(json);
                    fs.Write(data, 0, data.Length);
                    //清空缓冲区、关闭流
                    fs.Flush();
                    fs.Close();
                }
            }
        }
    }

    public class TestCaseModel { 
    
        public string CaseName { get; set; }
        public RequestModel RequestModel { get; set; }


        public string CanonicalRequest { get; set; }


        public string StringToSign { get; set; }

        public string Authorization { get; set; }

       
    }
}

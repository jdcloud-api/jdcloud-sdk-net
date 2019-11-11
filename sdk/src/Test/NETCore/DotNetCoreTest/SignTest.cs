using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Auth.Sign;
using JDCloudSDK.Core.Model;
using Newtonsoft.Json;
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
        public void TestSignCase() {
            List<TestCaseModel> readCaseExcel = GetTestCase();

            if (readCaseExcel != null && readCaseExcel.Count > 0) {
                WriteJsonFile(readCaseExcel);
            }

            IJDCloudSigner jDCloudSigner = new JDCloudSignerV3();
            List<SignedRequestModel> signedRequestModels = new List<SignedRequestModel>();
            foreach (var item in readCaseExcel) {
                var result = jDCloudSigner.Sign(item.RequestModel, new Credentials("ak", "sk"));
                //signedRequestModels.Add(result);
                if (result.CanonicalRequest != item.CanonicalRequest) {
                    _output.WriteLine($"test case CanonicalRequest error, , case name is {item.CaseName}" );
                }
                if(result.StringToSign != item.StringToSign)
                {
                    _output.WriteLine($"test case StringToSign error, , case name is {item.CaseName}"); 
                }
                if (result.SignedHeaders != item.Authorization)
                {
                    _output.WriteLine($"test case Authorization error, , case name is {item.CaseName}"); 
                }

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
                        
                        requestModel.RegionName = row.Cells[4].StringCellValue;
                        if (string.IsNullOrWhiteSpace(requestModel.RegionName)) {
                            break;
                        }
                        requestModel.ServiceName = row.Cells[5].StringCellValue;
                        string host = row.Cells[6].StringCellValue;
                        string header = row.Cells[7].StringCellValue;
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
                                else if(item.Value is List<string>) {
                                    foreach (var valueItem in (List<string>)item.Value) {
                                        requestModel.AddHeader(item.Key, valueItem);
                                    }
                                }
                                
                            }
                        }
                        string requestPath = row.Cells[8].StringCellValue;
                        requestModel.ResourcePath = requestPath;
                        string queryString = row.Cells[9].StringCellValue;
                        if (!string.IsNullOrWhiteSpace(queryString) && queryString != "空")
                        {
                            requestModel.QueryParameters = queryString;
                        }
                        if (!requestPath.StartsWith("/"))
                        {
                            requestPath = $"/{requestPath}";
                        }
                        if (!queryString.StartsWith("?"))
                        {
                            queryString = $"?{queryString}";
                        }
                        string url = $"{host}{requestPath}{queryString}";
                        Uri uri = new Uri(url);
                        requestModel.Uri = uri;
                        requestModel.HttpMethod = row.Cells[3].StringCellValue;
                        TestCaseModel testCaseModel = new TestCaseModel();
                        testCaseModel.RequestModel = requestModel;
                        testCaseModel.CaseName = row.Cells[1].StringCellValue;
                        testCaseModel.CanonicalRequest = row.Cells[10].StringCellValue;
                        testCaseModel.StringToSign = row.Cells[11].StringCellValue;
                        testCaseModel.Authorization = row.Cells[12].StringCellValue;
                        testCaseModels.Add(testCaseModel);

                    }
                }


            }
            return testCaseModels;

        }


        public static void WriteJsonFile(List<TestCaseModel> requestModels) {
            if (requestModels != null && requestModels.Count > 0) {
                string json = JsonConvert.SerializeObject(requestModels, Formatting.Indented);
                
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

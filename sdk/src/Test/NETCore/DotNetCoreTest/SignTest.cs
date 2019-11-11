using JDCloudSDK.Core.Model;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DotNetCoreTest
{
    public class SignTest
    {
        public static List<RequestModel> GetTestCase() {
            List<RequestModel> requestModels = new List<RequestModel>();
            using (FileStream fileStream = File.OpenRead("")) {
                XSSFWorkbook xSSFWorkbook = new XSSFWorkbook(fileStream);
                ISheet sheet = xSSFWorkbook.GetSheetAt(1);
                string ak = "ak";
                string sk = "sk";
                for (int j = 1; j < sheet.LastRowNum; j++) {
                    IRow row = sheet.GetRow(j);
                    if (row != null) {
                        RequestModel requestModel = new RequestModel();
                        string host = "apigw-internal-dev.cn-north-1.jcloudcs.com";
                        var port = 8000;
                        requestModel.RequestPort = port;
                        



                    }
                }

            
            }


                return requestModels;
        
        }
    }
}

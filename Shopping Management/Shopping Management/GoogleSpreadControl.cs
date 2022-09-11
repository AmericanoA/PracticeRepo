using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Data = Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Data;
using Newtonsoft.Json;

namespace Shopping_Management
{

    public class GoogleSpreadControl
    {
        #region /// 공통영역
        // 샘플에서는 SheetsService.Scope.SpreadsheetsReadonly 으로 되어있는데
        // 데이터를 추가, 수정, 삭제를 하기 위해서는 SheetsService.Scope.Spreadsheets 해준다.
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        static string spreadsheetId = "18NWA8JZwtomLon0XLhJhcFSl8rQn5iKMSEQgJmLP_cM";

        UserCredential credential;

        public GoogleSpreadControl()
        {
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }
        }
        public void AppendToGS(string TargetSheet, List<object> rawdatalist, int paramcount)
        {
            //API CREATE
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            #endregion
            string sheetrange = string.Format("!{0}:{1}", Convert.ToChar(64 + 1), Convert.ToChar(64 + paramcount));
            var range = TargetSheet + sheetrange;

            //var valueRange = new ValueRange()
            //{
            //    MajorDimension = "ROWS",                    // ROWS or COLUMNS
            //    Values = new List<IList<object>> { rawdatalist } // 추가할 데이터
            //};

            //           var request = service.Spreadsheets.Values.Append(valueRange, spreadsheetId, range);
            //         request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
            //       request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
            //     request.Execute();
        }

        public void DeleteToGS(string TargetSheet, List<object> rawdatalist, int paramcount)
        {
            //API CREATE
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            string sheetrange = string.Format("!{0}:{1}", Convert.ToChar(64 + 1), Convert.ToChar(64 + paramcount));
            var range = TargetSheet + sheetrange;

            //var valueRange = new ValueRange()
            //{
            //    MajorDimension = "ROWS",                    // ROWS or COLUMNS
            //    Values = new List<IList<object>> { rawdatalist } // 추가할 데이터
            //};

            //           var request = service.Spreadsheets.Values.Append(valueRange, spreadsheetId, range);
            //         request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
            //       request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
            //     request.Execute();
        }
        public DataTable DownloadToGS(string TargetSheet, int paramcount, int searchcount)
        {
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            // Sheet Col, row 지정 동적으로 변경필요
            string sheetrange = string.Format("!{0}1:{1}{2}", Convert.ToChar(64+1), Convert.ToChar(64+paramcount),searchcount);
            var range = TargetSheet + sheetrange;
            var request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            var response = request.Execute();
            var values = response.Values;
            DataTable dt;
            dt = new DataTable();
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    if (dt.Rows.Count == 0 && dt.Columns.Count == 0)
                    {
                        for (int i = 0; i < paramcount; i++)
                            dt.Columns.Add(row[i].ToString());
                    }
                    else
                    {
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < paramcount; i++)
                            dr[i] = row[i];
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }
        public void UpdateToGS(string TargetSheet )
        {
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            string valueInputOption = "RAW";  // TODO: Update placeholder value.


            // The new values to apply to the spreadsheet.
            List<Data.ValueRange> data = new List<Data.ValueRange>();

            var oblist = new List<object>() { "123456", "kim", "dddddd", "ggg", "sk hynix", "z,.z" };
            Data.ValueRange valueRange = new Data.ValueRange()
            {
                MajorDimension = "ROWS",
                Values = new List<IList<object>> { oblist },
                Range ="고객정보!A2"
            };
            data.Add(valueRange);
            Data.ValueRange valueRange1 = new Data.ValueRange()
            {
                MajorDimension = "ROWS",
                Values = new List<IList<object>> { oblist },
                Range = "고객정보!A3"
            };
            data.Add(valueRange1);
            // TODO: Assign values to desired properties of `requestBody`:
            Data.BatchUpdateValuesRequest requestBody = new Data.BatchUpdateValuesRequest();
            requestBody.ValueInputOption = valueInputOption;
            requestBody.Data = data;

            SpreadsheetsResource.ValuesResource.BatchUpdateRequest request = service.Spreadsheets.Values.BatchUpdate(requestBody, spreadsheetId);

            // To execute asynchronously in an async method, replace `request.Execute()` as shown:
            Data.BatchUpdateValuesResponse response = request.Execute();
            // Data.BatchUpdateValuesResponse response = await request.ExecuteAsync();

            // TODO: Change code below to process the `response` object:
            Console.WriteLine(JsonConvert.SerializeObject(response));
        }
    }
}

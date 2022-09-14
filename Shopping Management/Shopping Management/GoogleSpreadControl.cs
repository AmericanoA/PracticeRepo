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
using System.Linq;

namespace Shopping_Management
{

    public class GoogleSpreadControl
    {

        #region /// 공통영역
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
        public void AppendToGS(string TargetSheet, List<Data.ValueRange> appendlist, int paramcount)
        {
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            #endregion
            string sheetrange = string.Format("!{0}:{1}", Convert.ToChar(64 + 1), Convert.ToChar(64 + paramcount));
            var range = TargetSheet + sheetrange;

            foreach (var data in appendlist)
            {
                var request = service.Spreadsheets.Values.Append(data, spreadsheetId, range);
                request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
                request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
                request.Execute();
            }
        }

        public void ClearToGS(string TargetSheet, int paramcount, int dtrowcount)
        {
            //API CREATE
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            string sheetrange = string.Format("!{0}2:{1}{2}", Convert.ToChar(64 + 1), Convert.ToChar(64 + paramcount), dtrowcount + 1);
            var range = TargetSheet + sheetrange;
            List<string> ranges = new List<string>();

            ranges.Add(range);
            Data.BatchClearValuesRequest requestBody = new Data.BatchClearValuesRequest();
            requestBody.Ranges = ranges;

            SpreadsheetsResource.ValuesResource.BatchClearRequest request = service.Spreadsheets.Values.BatchClear(requestBody, spreadsheetId);
            Data.BatchClearValuesResponse response = request.Execute();
            Console.WriteLine(JsonConvert.SerializeObject(response));
        }
        public ManageDataTable DownloadToGS(string TargetSheet, int paramcount, int searchcount)
        {
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            // Sheet Col, row 지정 동적으로 변경필요
            string sheetrange = string.Format("!{0}1:{1}{2}", Convert.ToChar(64 + 1), Convert.ToChar(64 + paramcount), searchcount);
            var range = TargetSheet + sheetrange;
            var request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            var response = request.Execute();
            var values = response.Values;
            ManageDataTable dt;
            dt = new ManageDataTable();
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    if (dt.dt.Rows.Count == 0 && dt.dt.Columns.Count == 0)
                    {
                        for (int i = 0; i < paramcount; i++)
                            dt.dt.Columns.Add(row[i].ToString());
                    }
                    else
                    {
                        DataRow dr = dt.dt.NewRow();
                        for (int i = 0; i < paramcount; i++)
                            dr[i] = row[i];
                        dt.dt.Rows.Add(dr);
                    }
                }
                var maxcode = dt.dt.AsEnumerable().OrderByDescending(r => Convert.ToInt32(r.Field<string>("PK").ToString().Substring(1))).FirstOrDefault();
                if (maxcode != null)
                    dt.iLastPK = Convert.ToInt32(maxcode["PK"].ToString().Substring(1));
            }
            return dt;
        }
        public void UpdateToGS(List<Data.ValueRange> data)
        {
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            string valueInputOption = "RAW";
            Data.BatchUpdateValuesRequest requestBody = new Data.BatchUpdateValuesRequest();
            requestBody.ValueInputOption = valueInputOption;
            requestBody.Data = data;

            SpreadsheetsResource.ValuesResource.BatchUpdateRequest request = service.Spreadsheets.Values.BatchUpdate(requestBody, spreadsheetId);
            Data.BatchUpdateValuesResponse response = request.Execute();
        }
    }
}

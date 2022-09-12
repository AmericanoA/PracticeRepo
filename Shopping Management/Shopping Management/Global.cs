using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data = Google.Apis.Sheets.v4.Data;

namespace Shopping_Management
{
    public static class CompareInfo
    {
        public const int RowDataEqual = 1000;
        public const int RowCountNotEqual = 1001;
        public const int RowDataNotEqual = 1002;
    }

    public class GSSendDataList
    {
        public List<Data.ValueRange> UpdateList { get; set; }
        public List<string> ClearList { get; set; }
        public List<Data.ValueRange> AppendList { get; set; }

        public GSSendDataList()
        {
            UpdateList = new List<Data.ValueRange>();
            ClearList = new List<string>();
            AppendList = new List<Data.ValueRange>();
        }
    }
}

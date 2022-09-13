using System.Collections.Generic;
using System.Data;
using Data = Google.Apis.Sheets.v4.Data;

namespace Shopping_Management
{
    public static class CompareInfo
    {
        public const int RowDataEqual = 1000;
        public const int RowCountNotEqual = 1001;
        public const int RowDataNotEqual = 1002;
    }
    public class TotalDB
    {
        public Dictionary<string, ManageDataTable> remoteDic { get; set; }
        public Dictionary<string, ManageDataTable> localDic { get; set; }

        public TotalDB()
        {
            remoteDic = new Dictionary<string, ManageDataTable>();
            localDic = new Dictionary<string, ManageDataTable>();

            string[] sKey = new string[3] { "고객정보", "상품정보", "주문정보" };
            ManageDataTable[] remotedt = new ManageDataTable[3];
            ManageDataTable[] localdt = new ManageDataTable[3];

            for (int i = 0; i < remotedt.Length; i++)
            {
                remotedt[i] = new ManageDataTable();
                remoteDic.Add(sKey[i], remotedt[i]);
            }
            for (int i = 0; i < localdt.Length; i++)
            {
                localdt[i] = new ManageDataTable();
                localDic.Add(sKey[i], localdt[i]);
            }
        }


    }

    public class ManageDataTable
    {
        public DataTable dt { get; set; }
        public int iLastPK { get; set; }

        public ManageDataTable()
        {
            dt = new DataTable();
            iLastPK = 0;
        }
    }
    public class SendDataList
    {
        public List<Data.ValueRange> UpdateList { get; set; }
        public bool bClear { get; set; }
        public List<Data.ValueRange> AppendList { get; set; }

        public SendDataList()
        {

            UpdateList = new List<Data.ValueRange>();
            bClear = false;
            AppendList = new List<Data.ValueRange>();
        }

        public void SendListInit()
        {
            UpdateList = new List<Data.ValueRange>();
            bClear = false;
            AppendList = new List<Data.ValueRange>();
        }
    }
}

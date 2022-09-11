using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data = Google.Apis.Sheets.v4.Data;

namespace Shopping_Management
{
    public class DTManger
    {
        public DTManger()
        {

        }
        public int Compare_DataTable(DataTable remote, DataTable local)
        {
            if (remote.Rows.Count != local.Rows.Count || remote.Columns.Count != local.Columns.Count)
                return CompareInfo.RowCountNotEqual;


            for (int i = 0; i < remote.Rows.Count; i++)
            {
                for (int c = 0; c < remote.Columns.Count; c++)
                {
                    if (!Equals(remote.Rows[i][c], local.Rows[i][c]))
                        return CompareInfo.RowDataNotEqual;
                }
            }
            return CompareInfo.RowDataEqual;
        }
        public List<Data.ValueRange> Update_DataTable(string TargetSheet, DataTable remote, DataTable local)
        {
            List<Data.ValueRange> data = new List<Data.ValueRange>();
            string range = TargetSheet;
            for (int i = 0; i < remote.Rows.Count; i++)
            {
                for (int c = 0; c < remote.Columns.Count; c++)
                {
                    if (!Equals(remote.Rows[i][c], local.Rows[i][c]))
                    {
                        string cell = i.ToString(); 
                        var oblist = new List<object>() { remote.Rows[0][c] };
                        for (int x =  1; x < remote.Columns.Count; x++)
                        {
                            oblist.Add(remote.Rows[i][x]);
                        }
                        Data.ValueRange valueRange = new Data.ValueRange()
                        {
                            MajorDimension = "ROWS",
                            Values = new List<IList<object>> { oblist },
                            Range = $"{TargetSheet}!A{cell}"
                        };
                        data.Add(valueRange);
                        break;
                    }
                }
            }
            return data;
        }
    }
}

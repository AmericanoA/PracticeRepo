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
        public bool Compare_DataTable(DataTable remote, DataTable local)
        {
            //DataTable 일치확인
            if (remote.Rows.Count != local.Rows.Count || remote.Columns.Count != local.Columns.Count)
                return false;


            for (int i = 0; i < remote.Rows.Count; i++)
            {
                for (int c = 0; c < remote.Columns.Count; c++)
                {
                    if (!Equals(remote.Rows[i][c], local.Rows[i][c]))
                        return false;
                }
            }
            return true;
        }
        public List<Data.ValueRange> Update_DataTable_Old(string TargetSheet, DataTable remote, DataTable local)
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
        public  GSSendDataList GetSendDataList_DataTable(string TargetSheet, DataTable remote, DataTable local)
        {
            GSSendDataList gdl = new GSSendDataList();
            List<int> UpdateKey = new List<int>();
            List<int> DeleteKey = new List<int>();

            UpdateKey = UpdateKeySorting(remote, local);
            DeleteKey = ClearKeySorting(remote, local);
            gdl.AppendList = AppendDataSorting(remote, local);
            return gdl;
        }
        private List<int> UpdateKeySorting(DataTable remotedt, DataTable localdt)
        {
            List<int> updateindex = new List<int>();

            //속도확인후 세부수정

            for (int a = 0; a < remotedt.Rows.Count; a++)
            {
                for (int b = 0; b < localdt.Rows.Count; b++)
                {
                    if (Equals(remotedt.Rows[a][0], localdt.Rows[b][0]))
                    {
                        for (int c = 0; c < remotedt.Columns.Count; c++)
                        {
                            if (!Equals(remotedt.Rows[a][c], localdt.Rows[b][c]))
                            {
                                // 인덱스 괴리로 +1
                                updateindex.Add(a+1);
                                break;
                            }
                        }
                    }
                }
            }
            return updateindex;
        }
        private List<int> ClearKeySorting(DataTable remotedt, DataTable localdt)
        {
            List<int> clearindex = new List<int>();

            //속도확인후 세부수정

            for (int a = 0; a < remotedt.Rows.Count; a++)
            {
                for (int b = 0; b < localdt.Rows.Count; b++)
                {
                    if (Equals(remotedt.Rows[a][0], localdt.Rows[b][0]))
                        break;
                    else if (b >= localdt.Rows.Count - 1)
                        clearindex.Add(a+1);
                }
            }
            return clearindex;
        }
        private List<Data.ValueRange> AppendDataSorting(DataTable remotedt, DataTable localdt)
        {
            List<Data.ValueRange> appendlist = new List<Data.ValueRange>();

            if (remotedt.Rows.Count == 0)
            {
                for (int x = 0; x < localdt.Rows.Count; x++)
                {
                    var data = new List<object> { localdt.Rows[x][0] };
                    for (int i = 1; i < localdt.Columns.Count; i++)
                    {
                        data.Add(localdt.Rows[x][i]);
                    }
                  
                    Data.ValueRange appenddata = new Data.ValueRange()
                    {
                        MajorDimension = "ROWS",
                        Values = new List<IList<object>> { data }
                    };
                    appendlist.Add(appenddata);
                }
                return appendlist;
            }


            //속도확인후 세부수정
            for (int a = 0; a < remotedt.Rows.Count; a++)
            {
                for (int b = 0; b < localdt.Rows.Count; b++)
                {
                    if (Equals(remotedt.Rows[a][0], localdt.Rows[b][0]))
                        break;
                    else if (b >= localdt.Rows.Count - 1)
                    {
                        var data = new List<object> { localdt.Rows[b][0] };
                        for (int i = 1; i < localdt.Columns.Count; i++)
                        {
                            data.Add(localdt.Rows[b][i]);
                        }

                        Data.ValueRange appenddata = new Data.ValueRange()
                        {
                            MajorDimension = "ROWS",
                            Values = new List<IList<object>> { data }
                        };
                    appendlist.Add(appenddata);
                    }
                }
            }
            return appendlist;
        }
    }
}

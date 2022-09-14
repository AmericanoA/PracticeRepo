using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Shopping_Management
{
    public partial class SubForm_주문관리 : MetroForm
    {
        TotalDB _db = null;
        GoogleSpreadControl _spreadapi = null;
        DTManger _manager = null;

        SendDataList SendList = null;

        bool bEdit;
        int iEditRow;
        public SubForm_주문관리(TotalDB db, GoogleSpreadControl spreadapi, DTManger manager)
        {
            InitializeComponent();
            this._db = db;
            this._spreadapi = spreadapi;
            this._manager = manager;
            SendList = new SendDataList();
            bEdit = false;
            iEditRow = -1;
            dgv_주문관리.DataSource = _db.localDic["주문정보"].dt;
            dgv_주문관리.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {

        }

        private void SubForm_주문관리_Load(object sender, EventArgs e)
        {

        }
    }
}

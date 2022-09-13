using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Management
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        TotalDB db = null;
        GoogleSpreadControl spreadapi = null;
        DTManger manager = null;
        public MainForm()
        {
            InitializeComponent();
            db = new TotalDB();
            spreadapi = new GoogleSpreadControl();
            manager = new DTManger();

            db.remoteDic["고객정보"] = spreadapi.DownloadToGS("고객정보", 7, 500);
            db.remoteDic["상품정보"] = spreadapi.DownloadToGS("상품정보", 7, 500);
            db.remoteDic["주문정보"] = spreadapi.DownloadToGS("주문정보", 7, 500);

            if (db.remoteDic["고객정보"].dt.Columns.Count == 0)
            {
                db.remoteDic["고객정보"].dt.Columns.Add("PK");
                db.remoteDic["고객정보"].dt.Columns.Add("이름");
                db.remoteDic["고객정보"].dt.Columns.Add("ID");
                db.remoteDic["고객정보"].dt.Columns.Add("전화번호");
                db.remoteDic["고객정보"].dt.Columns.Add("주소");
                db.remoteDic["고객정보"].dt.Columns.Add("구매사이트");
                db.remoteDic["고객정보"].dt.Columns.Add("구매횟수");
            }
            if (db.remoteDic["상품정보"].dt.Columns.Count == 0)
            {
                db.remoteDic["상품정보"].dt.Columns.Add("PK");
                db.remoteDic["상품정보"].dt.Columns.Add("이름");
                db.remoteDic["상품정보"].dt.Columns.Add("ID");
                db.remoteDic["상품정보"].dt.Columns.Add("전화번호");
                db.remoteDic["상품정보"].dt.Columns.Add("주소");
                db.remoteDic["상품정보"].dt.Columns.Add("구매사이트");
                db.remoteDic["상품정보"].dt.Columns.Add("구매횟수");
            }
            if (db.remoteDic["주문정보"].dt.Columns.Count == 0)
            {
                db.remoteDic["주문정보"].dt.Columns.Add("PK");
                db.remoteDic["주문정보"].dt.Columns.Add("이름");
                db.remoteDic["주문정보"].dt.Columns.Add("ID");
                db.remoteDic["주문정보"].dt.Columns.Add("전화번호");
                db.remoteDic["주문정보"].dt.Columns.Add("주소");
                db.remoteDic["주문정보"].dt.Columns.Add("구매사이트");
                db.remoteDic["주문정보"].dt.Columns.Add("구매횟수");
            }
            db.localDic["고객정보"].dt = db.remoteDic["고객정보"].dt.Copy();
            db.localDic["고객정보"].iLastPK = db.remoteDic["고객정보"].iLastPK;
            db.localDic["상품정보"].dt = db.remoteDic["상품정보"].dt.Copy();
            db.localDic["상품정보"].iLastPK = db.remoteDic["상품정보"].iLastPK;
            db.localDic["주문정보"].dt = db.remoteDic["주문정보"].dt.Copy();
            db.localDic["주문정보"].iLastPK = db.remoteDic["주문정보"].iLastPK;

        }
        private void mtOrder_Click(object sender, EventArgs e)
        {
            SubForm_주문관리 주문 = new SubForm_주문관리();
            this.Hide();
            주문.ShowDialog();
            this.Show();
        }

        private void mtItem_Click(object sender, EventArgs e)
        {
            SubForm_상품관리 상품 = new SubForm_상품관리();
            this.Hide();
            상품.ShowDialog();
            this.Show();
        }

        private void mtCustomer_Click(object sender, EventArgs e)
        {
            SubForm_고객관리 고객 = new SubForm_고객관리(db,spreadapi,manager);
            this.Hide();
            고객.ShowDialog();
            this.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

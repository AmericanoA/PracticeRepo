using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Drawing;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace Shopping_Management
{
    public partial class SubForm_고객관리 : MetroForm
    {
        TotalDB _db = null;
        GoogleSpreadControl _spreadapi = null;
        DTManger _manager = null;

        SendDataList SendList = null;

        bool bEdit;
        int iEditRow;

        public SubForm_고객관리(TotalDB db, GoogleSpreadControl spreadapi, DTManger manager)
        {
            InitializeComponent();
            this._db = db;
            this._spreadapi = spreadapi;
            this._manager = manager;
            SendList = new SendDataList();
            bEdit = false;
            iEditRow = -1;
            dgv_고객관리.DataSource = _db.localDic["고객정보"].dt;
            dgv_고객관리.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb이름.Text) || string.IsNullOrEmpty(tbID.Text) || string.IsNullOrEmpty(tb전화번호.Text) || string.IsNullOrEmpty(tb주소.Text) || string.IsNullOrEmpty(tb구매사이트.Text))
            {
                MessageBox.Show("고객 정보가 입력되지 않았습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bEdit && iEditRow != -1)
            {
                DialogResult dr = MessageBox.Show("고객 정보를 해당 정보로 반영 하시겠습니까?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                _db.localDic["고객정보"].dt.Rows[iEditRow].SetField("이름", tb이름.Text);
                _db.localDic["고객정보"].dt.Rows[iEditRow].SetField("ID", tbID.Text);
                _db.localDic["고객정보"].dt.Rows[iEditRow].SetField("전화번호", tb전화번호.Text);
                _db.localDic["고객정보"].dt.Rows[iEditRow].SetField("주소", tb주소.Text);
                _db.localDic["고객정보"].dt.Rows[iEditRow].SetField("구매사이트", tb구매사이트.Text);

                bEdit = false;
                iEditRow = -1;

                dgv_고객관리.Enabled = true;
                dgv_고객관리.DefaultCellStyle.SelectionBackColor = Color.Gray;

                tb이름.Clear();
                tbID.Clear();
                tb전화번호.Clear();
                tb주소.Clear();
                tb구매사이트.Clear();

                MessageBox.Show("수정 사항 반영 되었습니다.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr = MessageBox.Show("고객 정보를 추가 하시겠습니까?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                _db.localDic["고객정보"].iLastPK = _db.localDic["고객정보"].iLastPK + 1;
                _db.localDic["고객정보"].dt.Rows.Add(string.Format("A{0:D4}", _db.localDic["고객정보"].iLastPK), tb이름.Text, tbID.Text, tb전화번호.Text, tb주소.Text, tb구매사이트.Text, 0);

                tb이름.Clear();
                tbID.Clear();
                tb전화번호.Clear();
                tb주소.Clear();
                tb구매사이트.Clear();

                MessageBox.Show("고객 정보 추가 되었습니다.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgv_고객관리.SelectedRows.Count > 1)
            {
                MessageBox.Show("한개의 행만 선택해 주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!bEdit)
            {
                DialogResult dr = MessageBox.Show("고객 정보 수정을 시작 하시겠습니까?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
                else
                {
                    DataGridViewRow dgvr = dgv_고객관리.SelectedRows[0];
                    tb이름.Text = dgvr.Cells["이름"].Value.ToString();
                    tbID.Text = dgvr.Cells["ID"].Value.ToString();
                    tb전화번호.Text = dgvr.Cells["전화번호"].Value.ToString();
                    tb주소.Text = dgvr.Cells["주소"].Value.ToString();
                    tb구매사이트.Text = dgvr.Cells["구매사이트"].Value.ToString();
                    bEdit = true;
                    iEditRow = dgvr.Index;
                    dgv_고객관리.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
                    dgv_고객관리.Enabled = false;
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("고객 정보 수정을 취소하시겠습니까?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
                else
                {
                    bEdit = false;
                    iEditRow = -1;
                    dgv_고객관리.Enabled = true;
                    dgv_고객관리.DefaultCellStyle.SelectionBackColor = Color.Gray;

                    MessageBox.Show("수정 취소 되었습니다.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCOPY_Click(object sender, EventArgs e)
        {
            if (bEdit)
            {
                MessageBox.Show("편집 모드를 해제하여 주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgv_고객관리.SelectedRows.Count > 1)
            {
                MessageBox.Show("한개의 행만 선택해 주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("해당 고객 정보를 복사 하시겠습니까?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            DataGridViewRow dgvr = dgv_고객관리.SelectedRows[0];
            tb이름.Text = dgvr.Cells["이름"].Value.ToString();
            tbID.Text = dgvr.Cells["ID"].Value.ToString();
            tb전화번호.Text = dgvr.Cells["전화번호"].Value.ToString();
            tb주소.Text = dgvr.Cells["주소"].Value.ToString();
            tb구매사이트.Text = dgvr.Cells["구매사이트"].Value.ToString();

            MessageBox.Show("고객 정보 복사 완료 되었습니다.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUPLOAD_Click(object sender, EventArgs e)
        {
            if (bEdit)
            {
                MessageBox.Show("편집 모드를 해제하여 주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_manager.Compare_DataTable(_db.remoteDic["고객정보"].dt, _db.localDic["고객정보"].dt))
            {
                MessageBox.Show("변경사항이 없습니다.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SendList = _manager.GetSendDataList_DataTable("고객정보", _db.remoteDic["고객정보"].dt, _db.localDic["고객정보"].dt);
            if (SendList.bClear)
                _spreadapi.ClearToGS("고객정보", _db.remoteDic["고객정보"].dt.Columns.Count, _db.remoteDic["고객정보"].dt.Rows.Count);
            else
                _spreadapi.UpdateToGS(SendList.UpdateList);

            if (SendList.AppendList.Count > 0)
            {
                _spreadapi.AppendToGS("고객정보", SendList.AppendList, _db.remoteDic["고객정보"].dt.Columns.Count);
            }
            _db.remoteDic["고객정보"].dt = _db.localDic["고객정보"].dt.Copy();
            SendList.SendListInit();

            MessageBox.Show("서버 반영 완료 되었습니다.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (bEdit)
            {
                MessageBox.Show("편집 모드를 해제하여 주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgv_고객관리.SelectedRows.Count == 0)
            {
                MessageBox.Show("한개 이상의 행을 선택해 주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //PK 따라가게 OK
            int count = dgv_고객관리.SelectedRows.Count - 1;
            for (int i = count; i >= 0; i--)
            {
                string sPK = dgv_고객관리.SelectedRows[i].Cells[0].Value.ToString();
                foreach (DataRow row in _db.localDic["고객정보"].dt.Rows)
                {
                    if (row[0].ToString() == sPK)
                    {
                        row.Delete();
                        break;
                    }
                }
            }
            MessageBox.Show("고객 정보 삭제 완료 되었습니다.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
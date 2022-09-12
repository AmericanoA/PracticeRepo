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
        DataTable dtLocal = null;
        DataTable dtRemote = null;
        GoogleSpreadControl gsc = null;
        DTManger dtm = null;
        GSSendDataList SendList = null;
        bool bEdit;
        int iEditRow;

        public SubForm_고객관리()
        {
            InitializeComponent();

            bEdit = false;
            iEditRow = -1;
            gsc = new GoogleSpreadControl();
            dtm = new DTManger();

            dtLocal = new DataTable();
            dtRemote = new DataTable();
            SendList = new GSSendDataList();

            dgv_고객관리.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }

        private void SubForm_고객관리_Load(object sender, EventArgs e)
        {
            dtRemote = gsc.DownloadToGS("고객정보", 7, 500);
            dtLocal = dtRemote.Copy();
            if (dtLocal.Columns.Count == 0)
            {
                dtLocal.Columns.Add("PK");
                dtLocal.Columns.Add("이름");
                dtLocal.Columns.Add("ID");
                dtLocal.Columns.Add("전화번호");
                dtLocal.Columns.Add("주소");
                dtLocal.Columns.Add("구매사이트");
                dtLocal.Columns.Add("구매횟수");
            }
            dgv_고객관리.DataSource = dtLocal;
        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb이름.Text) || string.IsNullOrEmpty(tbID.Text) || string.IsNullOrEmpty(tb전화번호.Text) || string.IsNullOrEmpty(tb주소.Text) || string.IsNullOrEmpty(tb구매사이트.Text))
            {
                MessageBox.Show("고객 정보가 입력되지 않았습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (bEdit && iEditRow != -1)
                {
                    DialogResult dr = MessageBox.Show("고객 정보를 수정 하시겠습니까?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    dtLocal.Rows[iEditRow].SetField("이름", tb이름.Text);
                    dtLocal.Rows[iEditRow].SetField("ID", tbID.Text);
                    dtLocal.Rows[iEditRow].SetField("전화번호", tb전화번호.Text);
                    dtLocal.Rows[iEditRow].SetField("주소", tb주소.Text);
                    dtLocal.Rows[iEditRow].SetField("구매사이트", tb구매사이트.Text);
                    bEdit = false;
                    iEditRow = -1;
                    dgv_고객관리.Enabled = true;
                    dgv_고객관리.DefaultCellStyle.SelectionBackColor = Color.Gray;
                    tb이름.Clear();
                    tbID.Clear();
                    tb전화번호.Clear();
                    tb주소.Clear();
                    tb구매사이트.Clear();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("고객 정보를 추가 하시겠습니까?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }

                    dtLocal.Rows.Add(string.Format("A" + "{0:D4}", dtLocal.Rows.Count), tb이름.Text, tbID.Text, tb전화번호.Text, tb주소.Text, tb구매사이트.Text, 0);
                    tb이름.Clear();
                    tbID.Clear();
                    tb전화번호.Clear();
                    tb주소.Clear();
                    tb구매사이트.Clear();
                }
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (dgv_고객관리.SelectedRows.Count == 1 && !bEdit)
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
            else if (bEdit)
            {
                bEdit = false;
                iEditRow = -1;
                dgv_고객관리.Enabled = true;
                dgv_고객관리.DefaultCellStyle.SelectionBackColor = Color.Gray;
            }
            else
            {
                MessageBox.Show("한개의 행만 선택해 주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCOPY_Click(object sender, EventArgs e)
        {
            if (dgv_고객관리.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvr = dgv_고객관리.SelectedRows[0];
                tb이름.Text = dgvr.Cells["이름"].Value.ToString();
                tbID.Text = dgvr.Cells["ID"].Value.ToString();
                tb전화번호.Text = dgvr.Cells["전화번호"].Value.ToString();
                tb주소.Text = dgvr.Cells["주소"].Value.ToString();
                tb구매사이트.Text = dgvr.Cells["구매사이트"].Value.ToString();
            }
            else
            {
                MessageBox.Show("한개의 행만 선택해 주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUPLOAD_Click(object sender, EventArgs e)
        {
            if (dtLocal.Rows.Count == 0)
            {
                MessageBox.Show("고객정보가 존재하지 않습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtm.Compare_DataTable(dtRemote, dtLocal))
            {
                MessageBox.Show("변경사항이 없습니다.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                SendList = dtm.GetSendDataList_DataTable("고객정보", dtRemote, dtLocal);

        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (dgv_고객관리.SelectedRows.Count >= 1)
            {
                int count = dgv_고객관리.SelectedRows.Count-1;
                for (int i = count; i >= 0; i--)
                {
                    int index = dgv_고객관리.SelectedRows[i].Index;
                    dtLocal.Rows.RemoveAt(index);
                }
            }
            else
                MessageBox.Show("1개 이상의 행을 선택해 주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTEST_Click(object sender, EventArgs e)
        {
            gsc.ClearToGS("고객정보", 7 , dtRemote.Rows.Count);
        }
    }
}
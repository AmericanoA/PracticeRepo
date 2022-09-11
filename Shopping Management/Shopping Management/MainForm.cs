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
        public MainForm()
        {
            InitializeComponent();
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
            SubForm_고객관리 고객 = new SubForm_고객관리();
            this.Hide();
            고객.ShowDialog();
            this.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

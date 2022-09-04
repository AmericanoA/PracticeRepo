using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest
{
    public partial class Form1 : Form
    {
        string sCheck;
        public Form1()
        {
            InitializeComponent();
            sCheck = "Version Zero";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            sCheck = "Version Three";
            MessageBox.Show(sCheck);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sCheck = "Version Two";
        }
    }
}

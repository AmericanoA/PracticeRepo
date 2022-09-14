namespace Shopping_Management
{
    partial class SubForm_주문관리
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubForm_주문관리));
            this.dgv_주문관리 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb거래처 = new MetroFramework.Controls.MetroTextBox();
            this.tb출고가 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tb제품명 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tb입고가 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tb분류 = new MetroFramework.Controls.MetroTextBox();
            this.btnDELETE = new MetroFramework.Controls.MetroButton();
            this.btnINSERT = new MetroFramework.Controls.MetroButton();
            this.btnCOPY = new MetroFramework.Controls.MetroButton();
            this.btnEDIT = new MetroFramework.Controls.MetroButton();
            this.btnUPLOAD = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_주문관리)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_주문관리
            // 
            this.dgv_주문관리.AllowUserToAddRows = false;
            this.dgv_주문관리.AllowUserToDeleteRows = false;
            this.dgv_주문관리.AllowUserToResizeRows = false;
            this.dgv_주문관리.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_주문관리.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_주문관리.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_주문관리.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_주문관리.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_주문관리.GridColor = System.Drawing.Color.Azure;
            this.dgv_주문관리.Location = new System.Drawing.Point(23, 58);
            this.dgv_주문관리.Name = "dgv_주문관리";
            this.dgv_주문관리.ReadOnly = true;
            this.dgv_주문관리.RowTemplate.Height = 23;
            this.dgv_주문관리.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_주문관리.Size = new System.Drawing.Size(625, 519);
            this.dgv_주문관리.TabIndex = 0;
            this.dgv_주문관리.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnUPLOAD);
            this.groupBox3.Location = new System.Drawing.Point(679, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 235);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "상품 정보";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tb거래처);
            this.groupBox4.Controls.Add(this.tb출고가);
            this.groupBox4.Controls.Add(this.metroLabel6);
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Controls.Add(this.metroLabel9);
            this.groupBox4.Controls.Add(this.metroLabel10);
            this.groupBox4.Controls.Add(this.tb제품명);
            this.groupBox4.Controls.Add(this.metroLabel7);
            this.groupBox4.Controls.Add(this.tb입고가);
            this.groupBox4.Controls.Add(this.metroLabel8);
            this.groupBox4.Controls.Add(this.tb분류);
            this.groupBox4.Controls.Add(this.btnDELETE);
            this.groupBox4.Controls.Add(this.btnINSERT);
            this.groupBox4.Controls.Add(this.btnCOPY);
            this.groupBox4.Controls.Add(this.btnEDIT);
            this.groupBox4.Location = new System.Drawing.Point(6, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 166);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "정보 추가";
            // 
            // tb거래처
            // 
            this.tb거래처.Location = new System.Drawing.Point(63, 136);
            this.tb거래처.Name = "tb거래처";
            this.tb거래처.Size = new System.Drawing.Size(110, 23);
            this.tb거래처.TabIndex = 5;
            // 
            // tb출고가
            // 
            this.tb출고가.Location = new System.Drawing.Point(63, 78);
            this.tb출고가.Name = "tb출고가";
            this.tb출고가.Size = new System.Drawing.Size(110, 23);
            this.tb출고가.TabIndex = 3;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 136);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "거래처";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(6, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 16;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 107);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(53, 19);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "분    류";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 20);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(51, 19);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "제품명";
            // 
            // tb제품명
            // 
            this.tb제품명.Location = new System.Drawing.Point(63, 20);
            this.tb제품명.Name = "tb제품명";
            this.tb제품명.Size = new System.Drawing.Size(200, 23);
            this.tb제품명.TabIndex = 1;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 78);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "출고가";
            // 
            // tb입고가
            // 
            this.tb입고가.Location = new System.Drawing.Point(63, 49);
            this.tb입고가.Name = "tb입고가";
            this.tb입고가.Size = new System.Drawing.Size(110, 23);
            this.tb입고가.TabIndex = 2;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 49);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "입고가";
            // 
            // tb분류
            // 
            this.tb분류.Location = new System.Drawing.Point(63, 107);
            this.tb분류.Name = "tb분류";
            this.tb분류.Size = new System.Drawing.Size(110, 23);
            this.tb분류.TabIndex = 4;
            // 
            // btnDELETE
            // 
            this.btnDELETE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDELETE.Location = new System.Drawing.Point(292, 107);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(90, 23);
            this.btnDELETE.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDELETE.TabIndex = 14;
            this.btnDELETE.TabStop = false;
            this.btnDELETE.Text = "DELETE";
            // 
            // btnINSERT
            // 
            this.btnINSERT.Location = new System.Drawing.Point(292, 20);
            this.btnINSERT.Name = "btnINSERT";
            this.btnINSERT.Size = new System.Drawing.Size(90, 23);
            this.btnINSERT.TabIndex = 12;
            this.btnINSERT.TabStop = false;
            this.btnINSERT.Text = "INSERT";
            this.btnINSERT.Click += new System.EventHandler(this.btnINSERT_Click);
            // 
            // btnCOPY
            // 
            this.btnCOPY.Location = new System.Drawing.Point(292, 78);
            this.btnCOPY.Name = "btnCOPY";
            this.btnCOPY.Size = new System.Drawing.Size(90, 23);
            this.btnCOPY.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCOPY.TabIndex = 13;
            this.btnCOPY.TabStop = false;
            this.btnCOPY.Text = "COPY";
            // 
            // btnEDIT
            // 
            this.btnEDIT.Location = new System.Drawing.Point(292, 49);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(90, 23);
            this.btnEDIT.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnEDIT.TabIndex = 0;
            this.btnEDIT.TabStop = false;
            this.btnEDIT.Text = "EDIT";
            // 
            // btnUPLOAD
            // 
            this.btnUPLOAD.Location = new System.Drawing.Point(280, 206);
            this.btnUPLOAD.Name = "btnUPLOAD";
            this.btnUPLOAD.Size = new System.Drawing.Size(114, 23);
            this.btnUPLOAD.TabIndex = 1;
            this.btnUPLOAD.TabStop = false;
            this.btnUPLOAD.Text = "UPLOAD";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 36);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "주문 관리";
            // 
            // SubForm_주문관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 600);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv_주문관리);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SubForm_주문관리";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.SubForm_주문관리_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_주문관리)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_주문관리;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox tb분류;
        private MetroFramework.Controls.MetroTextBox tb거래처;
        private MetroFramework.Controls.MetroTextBox tb출고가;
        private MetroFramework.Controls.MetroTextBox tb제품명;
        private MetroFramework.Controls.MetroButton btnINSERT;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnEDIT;
        private MetroFramework.Controls.MetroButton btnUPLOAD;
        private MetroFramework.Controls.MetroButton btnCOPY;
        private MetroFramework.Controls.MetroButton btnDELETE;
        private MetroFramework.Controls.MetroTextBox tb입고가;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
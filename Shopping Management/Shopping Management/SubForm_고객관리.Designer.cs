namespace Shopping_Management
{
    partial class SubForm_고객관리
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubForm_고객관리));
            this.dgv_고객관리 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDELETE = new MetroFramework.Controls.MetroButton();
            this.btnCOPY = new MetroFramework.Controls.MetroButton();
            this.btnEDIT = new MetroFramework.Controls.MetroButton();
            this.btnUPLOAD = new MetroFramework.Controls.MetroButton();
            this.tb구매사이트 = new MetroFramework.Controls.MetroTextBox();
            this.tb주소 = new MetroFramework.Controls.MetroTextBox();
            this.tb전화번호 = new MetroFramework.Controls.MetroTextBox();
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.tb이름 = new MetroFramework.Controls.MetroTextBox();
            this.btnINSERT = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_고객관리)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_고객관리
            // 
            this.dgv_고객관리.AllowUserToAddRows = false;
            this.dgv_고객관리.AllowUserToDeleteRows = false;
            this.dgv_고객관리.AllowUserToResizeRows = false;
            this.dgv_고객관리.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_고객관리.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_고객관리.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_고객관리.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_고객관리.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_고객관리.GridColor = System.Drawing.Color.Azure;
            this.dgv_고객관리.Location = new System.Drawing.Point(20, 210);
            this.dgv_고객관리.Name = "dgv_고객관리";
            this.dgv_고객관리.ReadOnly = true;
            this.dgv_고객관리.RowTemplate.Height = 23;
            this.dgv_고객관리.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_고객관리.Size = new System.Drawing.Size(754, 364);
            this.dgv_고객관리.TabIndex = 0;
            this.dgv_고객관리.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(20, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 178);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "고객 정보";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDELETE);
            this.groupBox4.Controls.Add(this.btnCOPY);
            this.groupBox4.Controls.Add(this.btnEDIT);
            this.groupBox4.Controls.Add(this.btnUPLOAD);
            this.groupBox4.Controls.Add(this.tb구매사이트);
            this.groupBox4.Controls.Add(this.tb주소);
            this.groupBox4.Controls.Add(this.tb전화번호);
            this.groupBox4.Controls.Add(this.tbID);
            this.groupBox4.Controls.Add(this.tb이름);
            this.groupBox4.Controls.Add(this.btnINSERT);
            this.groupBox4.Controls.Add(this.metroLabel6);
            this.groupBox4.Controls.Add(this.metroLabel7);
            this.groupBox4.Controls.Add(this.metroLabel8);
            this.groupBox4.Controls.Add(this.metroLabel9);
            this.groupBox4.Controls.Add(this.metroLabel10);
            this.groupBox4.Location = new System.Drawing.Point(6, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(736, 152);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "정보 추가";
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(616, 122);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(114, 23);
            this.btnDELETE.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDELETE.TabIndex = 14;
            this.btnDELETE.TabStop = false;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnCOPY
            // 
            this.btnCOPY.Location = new System.Drawing.Point(616, 93);
            this.btnCOPY.Name = "btnCOPY";
            this.btnCOPY.Size = new System.Drawing.Size(114, 23);
            this.btnCOPY.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCOPY.TabIndex = 13;
            this.btnCOPY.TabStop = false;
            this.btnCOPY.Text = "COPY";
            this.btnCOPY.Click += new System.EventHandler(this.btnCOPY_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.Location = new System.Drawing.Point(616, 64);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(114, 23);
            this.btnEDIT.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnEDIT.TabIndex = 0;
            this.btnEDIT.TabStop = false;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnUPLOAD
            // 
            this.btnUPLOAD.Location = new System.Drawing.Point(6, 122);
            this.btnUPLOAD.Name = "btnUPLOAD";
            this.btnUPLOAD.Size = new System.Drawing.Size(114, 23);
            this.btnUPLOAD.TabIndex = 1;
            this.btnUPLOAD.TabStop = false;
            this.btnUPLOAD.Text = "UPLOAD";
            this.btnUPLOAD.Click += new System.EventHandler(this.btnUPLOAD_Click);
            // 
            // tb구매사이트
            // 
            this.tb구매사이트.Location = new System.Drawing.Point(470, 35);
            this.tb구매사이트.Name = "tb구매사이트";
            this.tb구매사이트.Size = new System.Drawing.Size(110, 23);
            this.tb구매사이트.TabIndex = 5;
            // 
            // tb주소
            // 
            this.tb주소.Location = new System.Drawing.Point(354, 35);
            this.tb주소.Name = "tb주소";
            this.tb주소.Size = new System.Drawing.Size(110, 23);
            this.tb주소.TabIndex = 4;
            // 
            // tb전화번호
            // 
            this.tb전화번호.Location = new System.Drawing.Point(238, 35);
            this.tb전화번호.Name = "tb전화번호";
            this.tb전화번호.Size = new System.Drawing.Size(110, 23);
            this.tb전화번호.TabIndex = 3;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(122, 35);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(110, 23);
            this.tbID.TabIndex = 2;
            // 
            // tb이름
            // 
            this.tb이름.Location = new System.Drawing.Point(6, 35);
            this.tb이름.Name = "tb이름";
            this.tb이름.Size = new System.Drawing.Size(110, 23);
            this.tb이름.TabIndex = 1;
            // 
            // btnINSERT
            // 
            this.btnINSERT.Location = new System.Drawing.Point(616, 35);
            this.btnINSERT.Name = "btnINSERT";
            this.btnINSERT.Size = new System.Drawing.Size(114, 23);
            this.btnINSERT.TabIndex = 12;
            this.btnINSERT.TabStop = false;
            this.btnINSERT.Text = "INSERT";
            this.btnINSERT.Click += new System.EventHandler(this.btnINSERT_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(470, 17);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 15);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "구매사이트";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(354, 17);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(31, 15);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "주소";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.Location = new System.Drawing.Point(238, 17);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(55, 15);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "전화번호";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.Location = new System.Drawing.Point(122, 17);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(18, 15);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "ID";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.Location = new System.Drawing.Point(6, 17);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(31, 15);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "이름";
            // 
            // SubForm_고객관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv_고객관리);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SubForm_고객관리";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_고객관리)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_고객관리;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox tb구매사이트;
        private MetroFramework.Controls.MetroTextBox tb주소;
        private MetroFramework.Controls.MetroTextBox tb전화번호;
        private MetroFramework.Controls.MetroTextBox tbID;
        private MetroFramework.Controls.MetroTextBox tb이름;
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
    }
}
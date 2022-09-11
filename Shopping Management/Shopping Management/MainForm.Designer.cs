namespace Shopping_Management
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.mtCustomer = new MetroFramework.Controls.MetroTile();
            this.mtItem = new MetroFramework.Controls.MetroTile();
            this.mtOrder = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "By Code Monster";
            // 
            // mtCustomer
            // 
            this.mtCustomer.Location = new System.Drawing.Point(434, 63);
            this.mtCustomer.Name = "mtCustomer";
            this.mtCustomer.Size = new System.Drawing.Size(200, 200);
            this.mtCustomer.TabIndex = 2;
            this.mtCustomer.Text = "고객 관리";
            this.mtCustomer.TileImage = global::Shopping_Management.Properties.Resources.고객관리;
            this.mtCustomer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCustomer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCustomer.UseTileImage = true;
            this.mtCustomer.Click += new System.EventHandler(this.mtCustomer_Click);
            // 
            // mtItem
            // 
            this.mtItem.Location = new System.Drawing.Point(228, 63);
            this.mtItem.Name = "mtItem";
            this.mtItem.Size = new System.Drawing.Size(200, 200);
            this.mtItem.Style = MetroFramework.MetroColorStyle.Green;
            this.mtItem.TabIndex = 1;
            this.mtItem.Text = "상품 관리";
            this.mtItem.TileImage = global::Shopping_Management.Properties.Resources.상품관리;
            this.mtItem.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtItem.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtItem.UseTileImage = true;
            this.mtItem.Click += new System.EventHandler(this.mtItem_Click);
            // 
            // mtOrder
            // 
            this.mtOrder.BackColor = System.Drawing.Color.White;
            this.mtOrder.Location = new System.Drawing.Point(23, 63);
            this.mtOrder.Name = "mtOrder";
            this.mtOrder.Size = new System.Drawing.Size(200, 200);
            this.mtOrder.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtOrder.TabIndex = 0;
            this.mtOrder.Text = "주문 관리";
            this.mtOrder.TileImage = global::Shopping_Management.Properties.Resources.주문관리;
            this.mtOrder.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtOrder.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtOrder.UseTileImage = true;
            this.mtOrder.Click += new System.EventHandler(this.mtOrder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtCustomer);
            this.Controls.Add(this.mtItem);
            this.Controls.Add(this.mtOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "DASH BOARD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtOrder;
        private MetroFramework.Controls.MetroTile mtCustomer;
        private MetroFramework.Controls.MetroTile mtItem;
        private System.Windows.Forms.Label label1;
    }
}


namespace QLNV
{
    partial class frm_PhongBan
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
            this.panInfo = new System.Windows.Forms.Panel();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtTeanID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFun = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grvPB = new System.Windows.Forms.DataGridView();
            this.PK_sMaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSdtPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panInfo.SuspendLayout();
            this.panelFun.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panInfo
            // 
            this.panInfo.Controls.Add(this.txtSoLuong);
            this.panInfo.Controls.Add(this.label6);
            this.panInfo.Controls.Add(this.txtPhone);
            this.panInfo.Controls.Add(this.txtAddress);
            this.panInfo.Controls.Add(this.txtTeamName);
            this.panInfo.Controls.Add(this.txtTeanID);
            this.panInfo.Controls.Add(this.label5);
            this.panInfo.Controls.Add(this.label4);
            this.panInfo.Controls.Add(this.label3);
            this.panInfo.Controls.Add(this.label2);
            this.panInfo.Location = new System.Drawing.Point(12, 48);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(490, 201);
            this.panInfo.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtSoLuong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSoLuong.Location = new System.Drawing.Point(177, 159);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 24);
            this.txtSoLuong.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(38, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng NV:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPhone.Location = new System.Drawing.Point(177, 129);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 24);
            this.txtPhone.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtAddress.Location = new System.Drawing.Point(177, 69);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(234, 54);
            this.txtAddress.TabIndex = 6;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtTeamName.Location = new System.Drawing.Point(177, 39);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(100, 24);
            this.txtTeamName.TabIndex = 5;
            // 
            // txtTeanID
            // 
            this.txtTeanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtTeanID.Location = new System.Drawing.Point(177, 4);
            this.txtTeanID.Name = "txtTeanID";
            this.txtTeanID.Size = new System.Drawing.Size(100, 24);
            this.txtTeanID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(35, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(23, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên phòng ban:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ phòng ban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng ban:";
            // 
            // panelFun
            // 
            this.panelFun.Controls.Add(this.btnSave);
            this.panelFun.Controls.Add(this.btnExit);
            this.panelFun.Controls.Add(this.txtSearch);
            this.panelFun.Controls.Add(this.btnBack);
            this.panelFun.Controls.Add(this.btnCancel);
            this.panelFun.Controls.Add(this.btnSearch);
            this.panelFun.Controls.Add(this.btnAlter);
            this.panelFun.Controls.Add(this.btnDelete);
            this.panelFun.Controls.Add(this.btnInsert);
            this.panelFun.Location = new System.Drawing.Point(508, 48);
            this.panelFun.Name = "panelFun";
            this.panelFun.Size = new System.Drawing.Size(280, 201);
            this.panelFun.TabIndex = 1;
            this.panelFun.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFun_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(219, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 29);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExit.Location = new System.Drawing.Point(9, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(262, 29);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(9, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(109, 22);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.Text = "Search ID";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBack.Location = new System.Drawing.Point(9, 105);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(262, 29);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Trang chủ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancel.Location = new System.Drawing.Point(9, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(262, 29);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSearch.Location = new System.Drawing.Point(161, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 26);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAlter.Location = new System.Drawing.Point(161, 35);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(52, 29);
            this.btnAlter.TabIndex = 11;
            this.btnAlter.Text = "Sửa";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDelete.Location = new System.Drawing.Point(69, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnInsert.Location = new System.Drawing.Point(9, 35);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(52, 29);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grvPB);
            this.panel3.Location = new System.Drawing.Point(12, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 211);
            this.panel3.TabIndex = 1;
            // 
            // grvPB
            // 
            this.grvPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_sMaPB,
            this.sTenPB,
            this.sDiaChi,
            this.sSdtPB});
            this.grvPB.Location = new System.Drawing.Point(12, 15);
            this.grvPB.Name = "grvPB";
            this.grvPB.Size = new System.Drawing.Size(761, 205);
            this.grvPB.TabIndex = 0;
            this.grvPB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPB_CellContentClick);
            // 
            // PK_sMaPB
            // 
            this.PK_sMaPB.DataPropertyName = "PK_sMaPB";
            this.PK_sMaPB.HeaderText = "Mã Phòng";
            this.PK_sMaPB.Name = "PK_sMaPB";
            this.PK_sMaPB.Width = 80;
            // 
            // sTenPB
            // 
            this.sTenPB.DataPropertyName = "sTenPB";
            this.sTenPB.HeaderText = "Tên phòng";
            this.sTenPB.Name = "sTenPB";
            this.sTenPB.Width = 150;
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa chỉ";
            this.sDiaChi.Name = "sDiaChi";
            this.sDiaChi.Width = 400;
            // 
            // sSdtPB
            // 
            this.sSdtPB.DataPropertyName = "sSdtPB";
            this.sSdtPB.HeaderText = "Số điện thoại";
            this.sSdtPB.Name = "sSdtPB";
            this.sSdtPB.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin phòng ban";
            // 
            // frm_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFun);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panInfo);
            this.Name = "frm_PhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phòng ban";
            this.Load += new System.EventHandler(this.frm_PhongBan_Load);
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            this.panelFun.ResumeLayout(false);
            this.panelFun.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtTeanID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFun;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView grvPB;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_sMaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSdtPB;
    }
}
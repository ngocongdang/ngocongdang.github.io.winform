namespace QLNV
{
    partial class frm_NV_TDHV
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grvTDHV = new System.Windows.Forms.DataGridView();
            this.panFun = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panInfo = new System.Windows.Forms.Panel();
            this.txtNVID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTDHV = new System.Windows.Forms.ComboBox();
            this.tblTrinhDoHocVanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bTLDataSet9 = new QLNV.BTLDataSet9();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblTrinhDoHocVanTableAdapter = new QLNV.BTLDataSet9TableAdapters.tblTrinhDoHocVanTableAdapter();
            this.PK_sMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTDHV)).BeginInit();
            this.panFun.SuspendLayout();
            this.panInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrinhDoHocVanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grvTDHV);
            this.panel3.Location = new System.Drawing.Point(12, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 276);
            this.panel3.TabIndex = 7;
            // 
            // grvTDHV
            // 
            this.grvTDHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTDHV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_sMaNV,
            this.sHoTen,
            this.dNgaySinh,
            this.sGioiTinh,
            this.sQueQuan,
            this.sSDT,
            this.sTDHV});
            this.grvTDHV.Location = new System.Drawing.Point(3, 3);
            this.grvTDHV.Name = "grvTDHV";
            this.grvTDHV.Size = new System.Drawing.Size(636, 269);
            this.grvTDHV.TabIndex = 0;
            this.grvTDHV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTDHV_CellContentClick);
            // 
            // panFun
            // 
            this.panFun.Controls.Add(this.btnLoad);
            this.panFun.Controls.Add(this.btnSave);
            this.panFun.Controls.Add(this.btnExit);
            this.panFun.Controls.Add(this.btnBack);
            this.panFun.Controls.Add(this.btnChange);
            this.panFun.Location = new System.Drawing.Point(449, 46);
            this.panFun.Name = "panFun";
            this.panFun.Size = new System.Drawing.Size(205, 167);
            this.panFun.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLoad.Location = new System.Drawing.Point(3, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(199, 29);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Xem danh sách";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(3, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 29);
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
            this.btnExit.Location = new System.Drawing.Point(3, 134);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(199, 29);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBack.Location = new System.Drawing.Point(3, 99);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(199, 29);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Trang chủ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnChange.Location = new System.Drawing.Point(3, 35);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(199, 29);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Thay đổi TDHV";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông tin nhân viên theo phòng ban ";
            // 
            // panInfo
            // 
            this.panInfo.Controls.Add(this.txtNVID);
            this.panInfo.Controls.Add(this.label5);
            this.panInfo.Controls.Add(this.txtName);
            this.panInfo.Controls.Add(this.txtSoLuong);
            this.panInfo.Controls.Add(this.label4);
            this.panInfo.Controls.Add(this.cbTDHV);
            this.panInfo.Controls.Add(this.label3);
            this.panInfo.Controls.Add(this.label2);
            this.panInfo.Location = new System.Drawing.Point(12, 46);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(431, 167);
            this.panInfo.TabIndex = 4;
            // 
            // txtNVID
            // 
            this.txtNVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVID.Location = new System.Drawing.Point(144, 96);
            this.txtNVID.Name = "txtNVID";
            this.txtNVID.Size = new System.Drawing.Size(212, 24);
            this.txtNVID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã  nhân viên ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(144, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 24);
            this.txtName.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(144, 58);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(78, 24);
            this.txtSoLuong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên nhân viên:";
            // 
            // cbTDHV
            // 
            this.cbTDHV.DataSource = this.tblTrinhDoHocVanBindingSource;
            this.cbTDHV.DisplayMember = "sTDHV";
            this.cbTDHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTDHV.FormattingEnabled = true;
            this.cbTDHV.Location = new System.Drawing.Point(144, 20);
            this.cbTDHV.Name = "cbTDHV";
            this.cbTDHV.Size = new System.Drawing.Size(212, 26);
            this.cbTDHV.TabIndex = 2;
            this.cbTDHV.ValueMember = "sTDHV";
            // 
            // tblTrinhDoHocVanBindingSource
            // 
            this.tblTrinhDoHocVanBindingSource.DataMember = "tblTrinhDoHocVan";
            this.tblTrinhDoHocVanBindingSource.DataSource = this.bTLDataSet9;
            // 
            // bTLDataSet9
            // 
            this.bTLDataSet9.DataSetName = "BTLDataSet9";
            this.bTLDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sô lượng NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trình độ HV:";
            // 
            // tblTrinhDoHocVanTableAdapter
            // 
            this.tblTrinhDoHocVanTableAdapter.ClearBeforeFill = true;
            // 
            // PK_sMaNV
            // 
            this.PK_sMaNV.DataPropertyName = "PK_sMaNV";
            this.PK_sMaNV.HeaderText = "MNV";
            this.PK_sMaNV.Name = "PK_sMaNV";
            this.PK_sMaNV.Width = 50;
            // 
            // sHoTen
            // 
            this.sHoTen.DataPropertyName = "sHoTen";
            this.sHoTen.HeaderText = "Họ tên";
            this.sHoTen.Name = "sHoTen";
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.DataPropertyName = "dNgaySinh";
            this.dNgaySinh.HeaderText = "Ngày sinh";
            this.dNgaySinh.Name = "dNgaySinh";
            // 
            // sGioiTinh
            // 
            this.sGioiTinh.DataPropertyName = "sGioiTinh";
            this.sGioiTinh.HeaderText = "Giới tính";
            this.sGioiTinh.Name = "sGioiTinh";
            this.sGioiTinh.Width = 50;
            // 
            // sQueQuan
            // 
            this.sQueQuan.DataPropertyName = "sQueQuan";
            this.sQueQuan.HeaderText = "Quê quán";
            this.sQueQuan.Name = "sQueQuan";
            // 
            // sSDT
            // 
            this.sSDT.DataPropertyName = "sSDT";
            this.sSDT.HeaderText = "SĐT";
            this.sSDT.Name = "sSDT";
            // 
            // sTDHV
            // 
            this.sTDHV.DataPropertyName = "sTDHV";
            this.sTDHV.HeaderText = "TĐHV";
            this.sTDHV.Name = "sTDHV";
            // 
            // frm_NV_TDHV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 503);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panFun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panInfo);
            this.Name = "frm_NV_TDHV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin trình độ học vấn";
            this.Load += new System.EventHandler(this.frm_NV_TDHV_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTDHV)).EndInit();
            this.panFun.ResumeLayout(false);
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrinhDoHocVanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panFun;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.TextBox txtNVID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTDHV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private BTLDataSet9 bTLDataSet9;
        private System.Windows.Forms.BindingSource tblTrinhDoHocVanBindingSource;
        private BTLDataSet9TableAdapters.tblTrinhDoHocVanTableAdapter tblTrinhDoHocVanTableAdapter;
        private System.Windows.Forms.DataGridView grvTDHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_sMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDHV;
    }
}
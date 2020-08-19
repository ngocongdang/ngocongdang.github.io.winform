namespace QLNV
{
    partial class frm_Luong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCapBac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtNVID = new System.Windows.Forms.TextBox();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.txtLCB = new System.Windows.Forms.TextBox();
            this.txtHSL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBacLuong = new System.Windows.Forms.ComboBox();
            this.tblLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bTLDataSet10 = new QLNV.BTLDataSet10();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblLuongTableAdapter = new QLNV.BTLDataSet10TableAdapters.tblLuongTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grvNV_L = new System.Windows.Forms.DataGridView();
            this.PK_sMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fHeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBacLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet10)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvNV_L)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCapBac);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtLuong);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.txtNVID);
            this.panel1.Controls.Add(this.txtPhuCap);
            this.panel1.Controls.Add(this.txtLCB);
            this.panel1.Controls.Add(this.txtHSL);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbBacLuong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 177);
            this.panel1.TabIndex = 0;
            // 
            // txtCapBac
            // 
            this.txtCapBac.Enabled = false;
            this.txtCapBac.Location = new System.Drawing.Point(397, 73);
            this.txtCapBac.Name = "txtCapBac";
            this.txtCapBac.Size = new System.Drawing.Size(115, 22);
            this.txtCapBac.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(257, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(289, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Công thức: lương = HSL*Lương cơ bản+Phụ cấp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cấp bậc:";
            // 
            // txtLuong
            // 
            this.txtLuong.Enabled = false;
            this.txtLuong.Location = new System.Drawing.Point(397, 101);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(115, 22);
            this.txtLuong.TabIndex = 13;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(397, 45);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(128, 22);
            this.txtTenNV.TabIndex = 12;
            // 
            // txtNVID
            // 
            this.txtNVID.Location = new System.Drawing.Point(397, 12);
            this.txtNVID.Name = "txtNVID";
            this.txtNVID.Size = new System.Drawing.Size(66, 22);
            this.txtNVID.TabIndex = 11;
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Enabled = false;
            this.txtPhuCap.Location = new System.Drawing.Point(107, 101);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(100, 22);
            this.txtPhuCap.TabIndex = 10;
            // 
            // txtLCB
            // 
            this.txtLCB.Enabled = false;
            this.txtLCB.Location = new System.Drawing.Point(107, 73);
            this.txtLCB.Name = "txtLCB";
            this.txtLCB.Size = new System.Drawing.Size(100, 22);
            this.txtLCB.TabIndex = 9;
            // 
            // txtHSL
            // 
            this.txtHSL.Enabled = false;
            this.txtHSL.Location = new System.Drawing.Point(107, 45);
            this.txtHSL.Name = "txtHSL";
            this.txtHSL.Size = new System.Drawing.Size(82, 22);
            this.txtHSL.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tổng lương:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên NV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã NV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(35, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phụ cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lương cơ bản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(58, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "HSL:";
            // 
            // cbBacLuong
            // 
            this.cbBacLuong.DataSource = this.tblLuongBindingSource;
            this.cbBacLuong.DisplayMember = "FK_BacLuong";
            this.cbBacLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbBacLuong.FormattingEnabled = true;
            this.cbBacLuong.Location = new System.Drawing.Point(107, 12);
            this.cbBacLuong.Name = "cbBacLuong";
            this.cbBacLuong.Size = new System.Drawing.Size(64, 24);
            this.cbBacLuong.TabIndex = 1;
            this.cbBacLuong.ValueMember = "FK_BacLuong";
            // 
            // tblLuongBindingSource
            // 
            this.tblLuongBindingSource.DataMember = "tblLuong";
            this.tblLuongBindingSource.DataSource = this.bTLDataSet10;
            // 
            // bTLDataSet10
            // 
            this.bTLDataSet10.DataSetName = "BTLDataSet10";
            this.bTLDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bậc Lương:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin lương";
            // 
            // tblLuongTableAdapter
            // 
            this.tblLuongTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.btnBangLuong);
            this.panel2.Controls.Add(this.btnChange);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel2.Location = new System.Drawing.Point(567, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 177);
            this.panel2.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(141, 38);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 29);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.Location = new System.Drawing.Point(3, 73);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(191, 29);
            this.btnBangLuong.TabIndex = 20;
            this.btnBangLuong.Text = "Xem bảng lương(Crystal)";
            this.btnBangLuong.UseVisualStyleBackColor = true;
            this.btnBangLuong.Click += new System.EventHandler(this.btnBangLuong_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(3, 38);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(132, 29);
            this.btnChange.TabIndex = 19;
            this.btnChange.Text = "Thay đổi bậc lương";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExit.Location = new System.Drawing.Point(3, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(191, 29);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBack.Location = new System.Drawing.Point(3, 108);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(191, 29);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Trang chủ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(3, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(191, 29);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Xem DSNV theo bậc lương";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grvNV_L);
            this.panel3.Location = new System.Drawing.Point(12, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 211);
            this.panel3.TabIndex = 3;
            // 
            // grvNV_L
            // 
            this.grvNV_L.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvNV_L.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_sMaNV,
            this.sHoTen,
            this.sChucVu,
            this.fHeSoLuong,
            this.sBacLuong,
            this.fLuongCoBan,
            this.fPhuCap,
            this.luong});
            this.grvNV_L.Location = new System.Drawing.Point(6, 3);
            this.grvNV_L.Name = "grvNV_L";
            this.grvNV_L.Size = new System.Drawing.Size(743, 208);
            this.grvNV_L.TabIndex = 0;
            this.grvNV_L.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvNV_L_CellContentClick);
            // 
            // PK_sMaNV
            // 
            this.PK_sMaNV.DataPropertyName = "PK_sMaNV";
            this.PK_sMaNV.HeaderText = "Mã NV";
            this.PK_sMaNV.Name = "PK_sMaNV";
            this.PK_sMaNV.Width = 50;
            // 
            // sHoTen
            // 
            this.sHoTen.DataPropertyName = "sHoTen";
            this.sHoTen.HeaderText = "Tên NV";
            this.sHoTen.Name = "sHoTen";
            // 
            // sChucVu
            // 
            this.sChucVu.DataPropertyName = "sChucVu";
            this.sChucVu.HeaderText = "Chức vụ";
            this.sChucVu.Name = "sChucVu";
            // 
            // fHeSoLuong
            // 
            this.fHeSoLuong.DataPropertyName = "fHeSoLuong";
            this.fHeSoLuong.HeaderText = "HSL";
            this.fHeSoLuong.Name = "fHeSoLuong";
            // 
            // sBacLuong
            // 
            this.sBacLuong.DataPropertyName = "sBacLuong";
            this.sBacLuong.HeaderText = "Bậc lương";
            this.sBacLuong.Name = "sBacLuong";
            this.sBacLuong.Width = 50;
            // 
            // fLuongCoBan
            // 
            this.fLuongCoBan.DataPropertyName = "fLuongCoBan";
            this.fLuongCoBan.HeaderText = "LCB";
            this.fLuongCoBan.Name = "fLuongCoBan";
            // 
            // fPhuCap
            // 
            this.fPhuCap.DataPropertyName = "fPhuCap";
            this.fPhuCap.HeaderText = "Phụ cấp";
            this.fPhuCap.Name = "fPhuCap";
            // 
            // luong
            // 
            this.luong.HeaderText = "Lương";
            this.luong.Name = "luong";
            // 
            // frm_Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Luong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Luong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet10)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvNV_L)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBacLuong;
        private BTLDataSet10 bTLDataSet10;
        private System.Windows.Forms.BindingSource tblLuongBindingSource;
        private BTLDataSet10TableAdapters.tblLuongTableAdapter tblLuongTableAdapter;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtNVID;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.TextBox txtLCB;
        private System.Windows.Forms.TextBox txtHSL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtCapBac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grvNV_L;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_sMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fHeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBacLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
    }
}
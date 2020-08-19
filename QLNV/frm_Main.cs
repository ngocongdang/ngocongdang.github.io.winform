using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }


        private void btnTTNV_Click(object sender, EventArgs e)
        {
            Frm_NV fNV = new Frm_NV();
            fNV.Show();
            this.Close();
        }

        private void btnLuongNV_Click(object sender, EventArgs e)
        {
            frm_Luong fLuong = new frm_Luong();
            fLuong.Show();
            this.Close();
        }

        private void btnTĐHV_Click(object sender, EventArgs e)
        {
            frm_NV_TDHV fTDHV = new frm_NV_TDHV();
            fTDHV.Show();
            this.Close();
        }

        private void btnNVPhongBan_Click(object sender, EventArgs e)
        {
            frm_PhongBanNV fPBNV = new frm_PhongBanNV();
            fPBNV.Show();
            this.Close();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            frm_PhongBan fPB = new frm_PhongBan();
            fPB.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

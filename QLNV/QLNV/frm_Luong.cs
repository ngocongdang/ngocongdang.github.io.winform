using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
{
    public partial class frm_Luong : Form
    {
        public frm_Luong()
        {
            InitializeComponent();
        }

        String conString = "Data Source=DESKTOP-78BBT0S;Initial Catalog=BTL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        private void frm_Luong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bTLDataSet10.tblLuong' table. You can move, or remove it, as needed.
            this.tblLuongTableAdapter.Fill(this.bTLDataSet10.tblLuong);
            loadNV_L();
        }

        public void tinhLuong()
        {
            foreach (DataGridViewRow row in grvNV_L.Rows)
            {
                row.Cells[grvNV_L.Columns["luong"].Index].Value = ((Convert.ToDouble(row.Cells[grvNV_L.Columns["fHeSoLuong"].Index].Value) * Convert.ToDouble(row.Cells[grvNV_L.Columns["fLuongCoBan"].Index].Value)) + Convert.ToDouble(row.Cells[grvNV_L.Columns["fPhuCap"].Index].Value));
            }
        }

        public void loadNV_L()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Closed) return;
                    using (SqlCommand cmd = new SqlCommand("LoadNV_L", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataSet ds = new DataSet();
                        da.Fill(ds, "customers");

                        DataTable dt = ds.Tables["customers"];
                        grvNV_L.DataSource = dt;
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            tinhLuong();
        }

        private void grvNV_L_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int test;
            test = e.RowIndex;
            txtNVID.Text = grvNV_L.Rows[test].Cells[1].Value.ToString();
            txtTenNV.Text = grvNV_L.Rows[test].Cells[2].Value.ToString();
            txtCapBac.Text = grvNV_L.Rows[test].Cells[3].Value.ToString();
            txtHSL.Text = grvNV_L.Rows[test].Cells[4].Value.ToString();
            cbBacLuong.Text = grvNV_L.Rows[test].Cells[5].Value.ToString();
            txtLCB.Text = grvNV_L.Rows[test].Cells[6].Value.ToString();
            txtPhuCap.Text = grvNV_L.Rows[test].Cells[7].Value.ToString();
            txtLuong.Text = grvNV_L.Rows[test].Cells[0].Value.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Closed) return;
                    using (SqlCommand cmd = new SqlCommand("SearchNV_L", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@bacLuong", cbBacLuong.SelectedValue.ToString()));
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        con.Close();
                        grvNV_L.DataSource = dt;

                    }
                    tinhLuong();
                    con.Close();
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Bạn muốn quay lại màn hình chính chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                frm_Main fMain = new frm_Main();
                fMain.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để sửa thông tin, hãy click vào nhân viên muốn sửa ở danh sách bên dưới, sau chọn bậc lương mong muốn và click OK!", "Thông báo!");
            btnChange.Enabled = false;
            btnShow.Enabled = false;
            btnBangLuong.Enabled = false;
            txtCapBac.Enabled = false;
            txtHSL.Enabled = false;
            txtLuong.Enabled = false;
            txtTenNV.Enabled = false;
            txtPhuCap.Enabled = false;
            txtLCB.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnChange.Enabled = true;
            btnShow.Enabled = true;
            btnBangLuong.Enabled = true;
            DialogResult close = MessageBox.Show(" Điều này sẽ gây thay đổi dữ liệu! Hãy chắc chắn rằng bạn muốn tiếp tục!\n\n\n Bạn có muốn tiến tục?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();
                        if (con.State == ConnectionState.Closed) return;
                        using (SqlCommand cmd = new SqlCommand("alterBacLuong", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@id", txtNVID.Text));
                            cmd.Parameters.Add(new SqlParameter("@bacLuong", cbBacLuong.SelectedValue.ToString()));
                            cmd.ExecuteNonQuery();
                            loadNV_L();
                        }
                    }
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }
        }
    }
}

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
    public partial class frm_NV_TDHV : Form
    {
        public frm_NV_TDHV()
        {
            InitializeComponent();
        }

        String conString = "Data Source=DESKTOP-78BBT0S;Initial Catalog=BTL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void frm_NV_TDHV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bTLDataSet9.tblTrinhDoHocVan' table. You can move, or remove it, as needed.
            this.tblTrinhDoHocVanTableAdapter.Fill(this.bTLDataSet9.tblTrinhDoHocVan);
            loadNV();
        }

        public void loadNV()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Closed) return;
                    using (SqlCommand cmd = new SqlCommand("loadTDHV", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataSet ds = new DataSet();
                        da.Fill(ds, "customers");

                        DataTable dt = ds.Tables["customers"];
                        grvTDHV.DataSource = dt;
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Bạn muốn quay lại màn hình chính chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                frm_Main fMain = new frm_Main();
                fMain.Show();
                this.Close();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để thay dổi trình độ học vấn, hãy click vào nhân viên bạn muốn sửa ở danh sách tình độ học vấn có nhân viên đó, sau đó chọn phòng bạn muốn chuyển đến và click Lưu!", "Thông báo!");

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtNVID.Text = "";
            txtName.Text = "";
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Closed) return;
                    using (SqlCommand cmd = new SqlCommand("LoadNV_TDHV", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@levelName", cbTDHV.SelectedValue.ToString()));
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        con.Close();
                        grvTDHV.DataSource = dt;
                    }
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("countNV_TDHV", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@levelName", cbTDHV.SelectedValue.ToString()));
                        txtSoLuong.Text = cmd.ExecuteScalar().ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show(" Điều này sẽ gây thay đổi dữ liệu! Hãy chắc chắn rằng bạn muốn tiếp tục!\n\n\n Bạn có muốn tiến tục?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();
                        if (con.State == ConnectionState.Closed) return;
                        using (SqlCommand cmd = new SqlCommand("ChagneLevel", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@id", txtNVID.Text));
                            cmd.Parameters.Add(new SqlParameter("@name", cbTDHV.SelectedValue.ToString()));
                            cmd.ExecuteNonQuery();
                            loadNV();
                        }
                    }
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy!", "Thông báo!");
            }
        }
        private void grvTDHV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int test;
            test = e.RowIndex;
            txtNVID.Text = grvTDHV.Rows[test].Cells[0].Value.ToString();
            txtName.Text = grvTDHV.Rows[test].Cells[1].Value.ToString();
            cbTDHV.Text = grvTDHV.Rows[test].Cells[6].Value.ToString();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("countNV_TDHV", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@levelName", cbTDHV.SelectedValue.ToString()));
                    txtSoLuong.Text = cmd.ExecuteScalar().ToString();
                }
                con.Close();
            }
        }
    }
}

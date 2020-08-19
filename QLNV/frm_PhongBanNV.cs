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
    public partial class frm_PhongBanNV : Form
    {
        public frm_PhongBanNV()
        {
            InitializeComponent();
        }

        String conString = "Data Source=DESKTOP-78BBT0S;Initial Catalog=BTL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void frm_PhongBanNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bTLDataSet8.tblPhongBan' table. You can move, or remove it, as needed.
            this.tblPhongBanTableAdapter.Fill(this.bTLDataSet8.tblPhongBan);
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
                    using (SqlCommand cmd = new SqlCommand("LoadNVT", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataSet ds = new DataSet();
                        da.Fill(ds, "customers");

                        DataTable dt = ds.Tables["customers"];
                        grvNV_PB.DataSource = dt;
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       

        private void btnMove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để chuyển đơn vị công tác, hãy click vào nhân viên bạn muốn sửa ở danh sách phòng có nhân viên đó, sau đó chọn phòng bạn muốn chuyển đến và click Lưu!", "Thông báo!");     
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
                    using (SqlCommand cmd = new SqlCommand("LoadNV_PB", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@teamName", cbPhongban.SelectedValue.ToString()));
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        con.Close();
                        grvNV_PB.DataSource = dt;
                    }
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("countNV_NPB", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@name", cbPhongban.SelectedValue.ToString()));
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

        private void grvNV_PB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int test;
            test = e.RowIndex;
            txtNVID.Text = grvNV_PB.Rows[test].Cells[0].Value.ToString();
            txtName.Text = grvNV_PB.Rows[test].Cells[1].Value.ToString();
            cbPhongban.Text = grvNV_PB.Rows[test].Cells[6].Value.ToString();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("countNV_NPB", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@name", cbPhongban.SelectedValue.ToString()));
                    txtSoLuong.Text = cmd.ExecuteScalar().ToString();
                }
                con.Close();
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
                        using (SqlCommand cmd = new SqlCommand("MoveNV", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@id", txtNVID.Text));
                            cmd.Parameters.Add(new SqlParameter("@name", cbPhongban.SelectedValue.ToString()));
                            cmd.ExecuteNonQuery();
                            loadNV();
                        }
                    }
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
                loadNV();
            }
            else
            {
                MessageBox.Show("Bạn đã hủy!", "Thông báo!");
            }
        }
    }
}

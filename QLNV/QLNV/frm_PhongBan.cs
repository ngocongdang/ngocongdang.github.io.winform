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
    public partial class frm_PhongBan : Form
    {
        public frm_PhongBan()
        {
            InitializeComponent();
        }

        String conString = "Data Source=DESKTOP-78BBT0S;Initial Catalog=BTL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void frm_PhongBan_Load(object sender, EventArgs e)
        {
            loadPB();
        }


        public void loadPB()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Closed) return;
                    using (SqlCommand cmd = new SqlCommand("LoadPB", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataSet ds = new DataSet();
                        da.Fill(ds, "customers");

                        DataTable dt = ds.Tables["customers"];
                        grvPB.DataSource = dt;
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void reset()
        {
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtSearch.Text = "";
            txtSoLuong.Text = "";
            txtTeamName.Text = "";
            txtTeanID.Text = "";
            btnInsert.Enabled = true;
            btnSave.Enabled = true;
            btnSearch.Enabled = true;
            btnAlter.Enabled = true;
            btnBack.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
            txtAddress.Enabled = true;
            txtPhone.Enabled = true;
            txtSearch.Enabled = true;
            txtTeamName.Enabled = true;
            txtTeanID.Enabled = true;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Closed) return;
                    using (SqlCommand cmd = new SqlCommand("SearchPB", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", txtSearch.Text));
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        con.Close();
                        grvPB.DataSource = dt;
                    }
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("countNV_PB", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", txtSearch.Text));
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Closed) return;
                    using (SqlCommand cmd = new SqlCommand("InsertPB", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", txtTeanID.Text));
                        cmd.Parameters.Add(new SqlParameter("@name", txtTeamName.Text));
                        cmd.Parameters.Add(new SqlParameter("@address", txtAddress.Text));
                        cmd.Parameters.Add(new SqlParameter("@phone", txtPhone.Text));
                        cmd.ExecuteNonQuery();
                        loadPB();
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để sửa thông tin, hãy click vào phòng ban muốn sửa ở  danh sách bên dưới, sau đó sửa thông tin và click Lưu!", "Thông báo!");
            reset();
            txtTeanID.Enabled = false;
            btnAlter.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = false;
            btnSearch.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            //panInfo.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show(" Điều này sẽ gây mất dữ liệu! Hãy chắc chắn rằng bạn muốn tiếp tục!\n\n\n Bạn có muốn tiến tục?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();
                        if (con.State == ConnectionState.Closed) return;
                        using (SqlCommand cmd = new SqlCommand("DeletePB", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@id", txtTeanID.Text));
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                    }
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
                loadPB();
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
                        using (SqlCommand cmd = new SqlCommand("AlterPB", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@id", txtTeanID.Text));
                            cmd.Parameters.Add(new SqlParameter("@name", txtTeamName.Text));
                            cmd.Parameters.Add(new SqlParameter("@address", txtAddress.Text));
                            cmd.Parameters.Add(new SqlParameter("@phone", txtPhone.Text));
                            cmd.ExecuteNonQuery();
                            loadPB();
                        }
                        reset();
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

        private void grvPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int test;
            test = e.RowIndex;
            txtTeanID.Text = grvPB.Rows[test].Cells[0].Value.ToString();
            txtTeamName.Text = grvPB.Rows[test].Cells[1].Value.ToString();
            txtAddress.Text = grvPB.Rows[test].Cells[2].Value.ToString();
            txtPhone.Text = grvPB.Rows[test].Cells[3].Value.ToString();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("countNV_PB", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id", txtTeanID.Text));
                    txtSoLuong.Text = cmd.ExecuteScalar().ToString();
                }
                con.Close();
            }
            
        }

        private void panelFun_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

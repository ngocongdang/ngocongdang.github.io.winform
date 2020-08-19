using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNV
{
    public partial class Frm_NV : Form
    {
        public Frm_NV()
        {
            InitializeComponent();
        }
        String conString = "Data Source=DESKTOP-78BBT0S;Initial Catalog=BTL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        int count = 0;
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bTLDataSet7.tblChucVu' table. You can move, or remove it, as needed.
            this.tblChucVuTableAdapter1.Fill(this.bTLDataSet7.tblChucVu);
            // TODO: This line of code loads data into the 'bTLDataSet6.tblTrinhDoHocVan' table. You can move, or remove it, as needed.
            this.tblTrinhDoHocVanTableAdapter.Fill(this.bTLDataSet6.tblTrinhDoHocVan);
            // TODO: This line of code loads data into the 'bTLDataSet5.tblChucVu' table. You can move, or remove it, as needed.
            this.tblChucVuTableAdapter.Fill(this.bTLDataSet5.tblChucVu);
            // TODO: This line of code loads data into the 'bTLDataSet4.tblLuong' table. You can move, or remove it, as needed.
            this.tblLuongTableAdapter.Fill(this.bTLDataSet4.tblLuong);
            // TODO: This line of code loads data into the 'bTLDataSet3.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.bTLDataSet3.tblNhanVien);
            // TODO: This line of code loads data into the 'bTLDataSet.tblPhongBan' table. You can move, or remove it, as needed.
            this.tblPhongBanTableAdapter.Fill(this.bTLDataSet.tblPhongBan);

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
                    using (SqlCommand cmd = new SqlCommand("LoadNV", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataSet ds = new DataSet();
                        da.Fill(ds, "customers");

                        DataTable dt = ds.Tables["customers"];
                        dataGridView1.DataSource = dt;
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
            panInfo.Enabled = true;
            panFun.Enabled = true;
            txtID.Text = null;
            txtName.Text = null;
            txtNation.Text = null;
            txtAddress.Text = null;
            txtPhone.Text = null;
            cbSex.Text = null;
            cbLevel.Text = null;
            cbOffice.Text = null;
            cbSalary.Text = null;
            cbTeam.Text = null;
            txtAddress.Enabled = true;
            txtID.Enabled = true; ;
            txtName.Enabled = true;
            txtNation.Enabled = true;
            txtPhone.Enabled = true;
            txtSearch.Enabled = true;
            btnAlter.Enabled = true;
            btnBack.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = true;
            btnSave.Enabled = true;
            btnSearch.Enabled = true;
        }

        public bool IsNull()
        {
            if (txtID.Text == "" || txtAddress.Text == "" || txtName.Text == "" || txtNation.Text == ""||txtPhone.Text==""||cbSex.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Closed) return;
                    using (SqlCommand cmd = new SqlCommand("SearchNV", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", txtSearch.Text));
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        con.Close();
                        dataGridView1.DataSource = dt;
                        
                    }
                    con.Close();
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            String IDTest = txtID.Text;
            if (IsNull())
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo!");
            }
            else 
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        int count = 0;
                        con.Open();
                        if (con.State == ConnectionState.Closed) return;
                        using (SqlCommand cmd = new SqlCommand("LoadIDNV", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                if (IDTest == dr["PK_sMaNV"].ToString())
                                {
                                    count++;
                                }
                            }
                            con.Close();
                        }
                        if (count != 0)
                        {
                            MessageBox.Show("Mã nhân viên này đã tồn tại vui lòng nhập lại!", "Thông báo!");
                            txtID.Text = "";
                        }
                        else
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand("InsertNV", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@id", txtID.Text));
                                cmd.Parameters.Add(new SqlParameter("@name", txtName.Text));
                                cmd.Parameters.Add(new SqlParameter("@DateOfBirth", dtpDateOfBirth.Value.ToString("yyyy/MM/dd")));
                                cmd.Parameters.Add(new SqlParameter("@Address", txtAddress.Text));
                                cmd.Parameters.Add(new SqlParameter("@Sex", cbSex.SelectedItem.ToString()));
                                cmd.Parameters.Add(new SqlParameter("@Nation",txtNation.Text));
                                cmd.Parameters.Add(new SqlParameter("@Phone", txtPhone.Text));
                                cmd.Parameters.Add(new SqlParameter("@TeamName", cbTeam.SelectedValue.ToString())) ;
                                cmd.Parameters.Add(new SqlParameter("@Office", cbOffice.SelectedValue.ToString()));
                                cmd.Parameters.Add(new SqlParameter("@Level", cbLevel.SelectedValue.ToString())) ;
                                cmd.Parameters.Add(new SqlParameter("@Salary", cbSalary.SelectedValue.ToString())) ;
                                cmd.ExecuteNonQuery();
                                loadNV();
                            }
                        }
                        con.Close();
                    }
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }
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
                        using (SqlCommand cmd = new SqlCommand("DeleteNV", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@id", txtID.Text));
                            cmd.ExecuteNonQuery();
                            con.Close();
                           
                        }
                    }
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
                loadNV();
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để sửa thông tin, hãy click vào nhân viên muốn sửa ở  danh sách bên dưới, sau đó sửa thông tin và click Lưu!", "Thông báo!");
            reset();
            //panInfo.Enabled = true;
            txtID.Enabled = false;
            btnAlter.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = false;
            btnSearch.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
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
            DialogResult close = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int test;
            test = e.RowIndex;
            txtID.Text = dataGridView1.Rows[test].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[test].Cells[1].Value.ToString();
            txtNation.Text = dataGridView1.Rows[test].Cells[5].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[test].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[test].Cells[6].Value.ToString();
            cbSex.Text = dataGridView1.Rows[test].Cells[4].Value.ToString();
            cbLevel.Text = dataGridView1.Rows[test].Cells[10].Value.ToString();
            cbOffice.Text = dataGridView1.Rows[test].Cells[9].Value.ToString();
            cbSalary.Text = dataGridView1.Rows[test].Cells[8].Value.ToString();
            cbTeam.Text = dataGridView1.Rows[test].Cells[7].Value.ToString();
            dtpDateOfBirth.Text = dataGridView1.Rows[test].Cells[2].Value.ToString();

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
                        using (SqlCommand cmd = new SqlCommand("AlterNV", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@id", txtID.Text));
                            cmd.Parameters.Add(new SqlParameter("@name", txtName.Text));
                            cmd.Parameters.Add(new SqlParameter("@DateOfBirth", dtpDateOfBirth.Value.ToString("yyyy/MM/dd")));
                            cmd.Parameters.Add(new SqlParameter("@Address", txtAddress.Text));
                            cmd.Parameters.Add(new SqlParameter("@Sex", cbSex.SelectedItem.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@Nation", txtNation.Text));
                            cmd.Parameters.Add(new SqlParameter("@Phone", txtPhone.Text));
                            cmd.Parameters.Add(new SqlParameter("@TeamName", cbTeam.SelectedValue.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@Office", cbOffice.SelectedValue.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@Level", cbLevel.SelectedValue.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@Salary", cbSalary.SelectedValue.ToString()));
                            cmd.ExecuteNonQuery();
                            loadNV();
                        }
                        reset(); 
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
                MessageBox.Show("Bạn đã hủy!","Thông báo!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

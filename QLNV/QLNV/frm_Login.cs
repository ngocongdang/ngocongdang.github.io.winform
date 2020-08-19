using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNV
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        String conString = "Data Source=DESKTOP-78BBT0S;Initial Catalog=BTL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private string getID(string username ,string password)
        {
            string id = "";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "btnLogin";
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@name", txtUsername.Text));
                        cmd.Parameters.Add(new SqlParameter("@pass", txtPassword.Text));
                        SqlDataReader dr = cmd.ExecuteReader();
                        int test = 0;
                        while (dr.Read())
                        {
                            id = dr["PK_ID"].ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Không thể kết nối !","Thông báo!");
                }
                finally
                {
                    con.Close();
                }
            }
           return id;
        }

        public static string ID_USER = "";
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                ID_USER = getID(txtUsername.Text, txtPassword.Text);
                if (ID_USER != "")
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông báo");
                    frm_Main fMain = new frm_Main();
                    fMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!","Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hãy Nhập đầy đủ thông tin", "Thông báo");
            }
        }
    }
}

using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data; 
namespace LTW_ContactApp
{

    public partial class Form1 : Form

    {

        string chuoiketnoi = @"Data Source=NamPNM;Initial Catalog=ContactData;Integrated Security=True;";

        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable DataTable = new DataTable();



        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from DanhBa", conn);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(DataTable);
                dataGridView1.DataSource = DataTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnESC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLoginName.Text.Trim();
            string password = tbLoginPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản và mật khẩu.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM TaiKhoan WHERE tentaikhoan = @username AND matkhau = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count == 1)
                        {
                            MessageBox.Show("Đăng nhập thành công!");
                            pnContactList.BringToFront(); 
                        }
                        else
                        {
                            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
            //pnContactList.BringToFront();
            //MaximizeBox = true; // Disable maximize button
            //FormBorderStyle = FormBorderStyle.Sizable; // Disable resizing
            //string username = tbLoginName.Text;
            //string password = tbLoginPass.Text;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            pnDangKy.BringToFront();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string SignInusername = tbName.Text.Trim();
            string SignInphone = tbSdt.Text.Trim();
            string SignInemail = tbEmail.Text.Trim();
            string SignInpassword = tbMatKhau.Text.Trim();
            string SignInrepassword = tbReMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(SignInusername) || string.IsNullOrEmpty(SignInemail) ||
                string.IsNullOrEmpty(SignInphone) || string.IsNullOrEmpty(SignInpassword)
                || string.IsNullOrEmpty(SignInrepassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                try
                {
                    conn.Open();

                  
                    string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE tentaikhoan = @username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", SignInusername);
                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0)
                        {
                            MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn tên khác.");
                            return;
                        }
                    }

                  
                    string insertQuery = @"INSERT INTO TaiKhoan (tentaikhoan, email, sodienthoai, matkhau)
                                   VALUES (@username, @email, @phone, @password)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", SignInusername);
                        cmd.Parameters.AddWithValue("@email", SignInemail);
                        cmd.Parameters.AddWithValue("@phone", SignInphone);
                        cmd.Parameters.AddWithValue("@password", SignInpassword);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký thành công!");
                           
                            pnDangNhap.BringToFront(); 
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
    
}

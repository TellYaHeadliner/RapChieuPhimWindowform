using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRapChieuPhim
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.SoDienThoai = txtBoxSDT.Text;
            user.MatKhau = txtBoxMatKhau.Text;
            if (user.SoDienThoai == "" || user.MatKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                int vaiTro = user.dangNhap(user.SoDienThoai, user.MatKhau);
                switch (vaiTro)
                {
                    case 1:
                        Admin form1 = new Admin(user.SoDienThoai);
                        form1.Show();
                        break;
                    case 2: case 3:
                        MessageBox.Show("Đăng nhập thành công");
                        break;
                    default:
                        MessageBox.Show("Đăng nhập thất bại");
                        break;
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void linkLabelForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

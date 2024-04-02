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
            if (user.MatKhau == "" || user.SoDienThoai == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                if (user.dangNhap(user.SoDienThoai, user.MatKhau) > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu của bạn sai");
                }
            }
        }
    }
}

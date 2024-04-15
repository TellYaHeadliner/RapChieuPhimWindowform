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
    public partial class UpdatePassword : Form
    {
        private string SDT;
        public UpdatePassword(string SDT)
        {
            this.SDT = SDT;
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtBoxUpdatePassword.Text != txtBoxConfirmPassword.Text)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cho chính xác");
            }
            else
            {
                User user = new User();
                user.SoDienThoai = SDT;
                user.MatKhau = txtBoxUpdatePassword.Text;
                if (user.updatePassword() == true)
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Có vấn đề cập nhật mật khẩu");
                }
            }
        }
    }
}

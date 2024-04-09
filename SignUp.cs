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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void lblTenNguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User client = new User();
            client.SoDienThoai = txtBoxSDT.Text;
            client.MatKhau = txtBoxMatKhau.Text;
            client.TenNguoiDung = txtBoxTNG.Text;
            client.CauHoiBaoMat = cbBoxCauHoiBaoMat.SelectedItem.ToString();
            client.CauTraLoiBaoMat = txtBoxCauTraLoi.Text;
            if (client.SoDienThoai == "" || client.MatKhau == "" || client.TenNguoiDung == "" || client.CauTraLoiBaoMat == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                 if (client.dangKi() == true)
                {
                    MessageBox.Show("Đăng kí thành công");
                }
                 else
                {
                    MessageBox.Show("Đăng kí thất bại");
                }
            }
        }
    }
}

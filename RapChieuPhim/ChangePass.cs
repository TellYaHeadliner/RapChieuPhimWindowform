using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim
{
    public partial class ChangePass : UserControl
    {
        public string sdt;

        // Khai báo một delegate cho sự kiện
        public delegate void SaveChange(object sender, EventArgs e);

        // Khai báo một sự kiện sử dụng delegate trên
        public event SaveChange saveChange;
        public ChangePass()
        {
          
            InitializeComponent();
        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            if (txbPassHienTai.Text.Trim().Length != 0 && txbPassMoi.Text==txbNhapLaiPass.Text)
            {
                if (TaiKhoan.ChangePass(sdt, txbPassHienTai.Text.Trim(), txbPassMoi.Text.Trim()))
                {
                    MessageBox.Show("Thay đổi thành công.", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbPassHienTai.Text = "";
                    txbPassMoi.Text = "";
                    txbNhapLaiPass.Text = "";
                    saveChange?.Invoke(this, e);
                    this.Visible = false;
                    return;
                }
            }
            MessageBox.Show("Mật khẩu mới không giống nhau!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnHuyPass_Click(object sender, EventArgs e)
        {
            txbPassHienTai.Text = "";
            txbPassMoi.Text = "";
            txbNhapLaiPass.Text = "";
            this.Visible = false;
        }
    }
}

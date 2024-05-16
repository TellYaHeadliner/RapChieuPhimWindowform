using BusinessLayer;
using Model;
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
    public partial class ReName : UserControl
    {
        public string sdt;

        // Khai báo một delegate cho sự kiện
        public delegate void SaveChange(object sender, EventArgs e);

        // Khai báo một sự kiện sử dụng delegate trên
        public event SaveChange saveChange;

        public ReName()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbRename.Text.Trim().Length != 0)
            {
                if (TaiKhoan.rename(sdt, txbRename.Text.Trim()))
                {
                    //tắt bảng rename;
                    MessageBox.Show("Thay đổi thành công.", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbRename.Text = "";
                    saveChange?.Invoke(this, e);
                    return;
                }
            }
            MessageBox.Show("Tên không hợp lệ.","Thông Báo!",MessageBoxButtons.OK,MessageBoxIcon.Error);    
        }

        private void huy_Click(object sender, EventArgs e)
        {
            txbRename.Text = "";
            this.Visible = false;
        }
    }
}

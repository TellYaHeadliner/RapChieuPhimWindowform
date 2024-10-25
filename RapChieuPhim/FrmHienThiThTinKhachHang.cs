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
    public partial class FrmHienThiThTinKhachHang : Form
    {
        TAIKHOAN tkhoan;
        public FrmHienThiThTinKhachHang(string sdt)
        {
            this.tkhoan = TaiKhoan.selectByID(sdt) ;
            InitializeComponent();
        }

        private void FrmHienThiThTinKhachHang_Load(object sender, EventArgs e)
        {
            hienThiTTKH();
            reName.Visible = false;
            changePass1.Visible = false;
        }

        private void hienThiTTKH()
        {
            tkhoan = TaiKhoan.selectByID(tkhoan.soDienThoai);
            labUserName.Text = tkhoan.tenNguoiDung;
            labSDT.Text = tkhoan.soDienThoai;

            switch (tkhoan.vaiTro)
            {
                case 1: labVaiTro.Text = "Admin"; break;
                case 2: labVaiTro.Text = "Nhân Viên Đăng Tin"; break;
                case 3: labVaiTro.Text = "Khách Hàng"; break;
            }
            reName.sdt = tkhoan.soDienThoai;
            changePass1.sdt = tkhoan.soDienThoai;
        }

        private void reName_saveChange(object sender, EventArgs e)
        {
            hienThiTTKH();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            reName.Visible = true;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            changePass1.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Model;

namespace BusinessLayer
{
    public class TaiKhoan
    {
        //Thay đổi thuộc tính thông báo của người dùng khi nhấn xem
        public static bool checkedThongBao(string sdt)
        {
            try
            {
                //Tạo đối tượng tài khoản có soDienThoai của người dùng
                TAIKHOAN tk = new TAIKHOAN() { soDienThoai = sdt };
                //Sử dụng để tìm đối tượng cần cập nhật và gán lại
                tk = DMTaiKhoan.run().selectByID(tk);
                //Thay đổi thuộc tính thông báo
                tk.thongBao = false;
                //update vào database
                return DMTaiKhoan.run().update(tk);
            }
            catch (Exception e) { }
            return false;
        }
        //Tìm đối tượng có sdt = số điện thoại truyền vào
        public static TAIKHOAN selectByID(string sdt)
        {
            return DMTaiKhoan.run().selectByID(new TAIKHOAN(){soDienThoai = sdt});
        }
        public static bool rename(string sdt,string ten)
        {
            try
            {
                TAIKHOAN t = DMTaiKhoan.run().selectByID(new TAIKHOAN() { soDienThoai = sdt });
                t.tenNguoiDung = ten;
                return DMTaiKhoan.run().update(t);
            }catch (Exception e) { 
                return false;
            }
        }
        public static bool ChangePass(string sdt, string lastPass, string newPass)
        {
            try
            {
                TAIKHOAN t = DMTaiKhoan.run().selectByID(new TAIKHOAN() { soDienThoai = sdt });
                if (lastPass != t.matKhau.Trim())
                    return false;
                t.matKhau = newPass;
                return DMTaiKhoan.run().update(t);
            }
            catch (Exception err) {
                return false;
            }
        }
    }
}

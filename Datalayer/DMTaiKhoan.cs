using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Datalayer
{
    public class DMTaiKhoan: IDM<TAIKHOAN>
    {
        private CINEMA_2Entities db = new CINEMA_2Entities();
        //Tạo phương thức static return class để không cần tạo đối tượng mới mỗi lần chạy
        public static DMTaiKhoan run()
        {
            return new DMTaiKhoan();
        }
        //Lấy tất cả đối tượng trong table
        public List<TAIKHOAN> selectAll()
        {
            throw new NotImplementedException();
        }
        //Lấy đối tượng theo id t.soDienThoai
        public TAIKHOAN selectByID(TAIKHOAN t)
        {
                return db.TAIKHOANs.Find(t.soDienThoai);
        }
        //Thêm đối tượng t vào table
        public bool insert(TAIKHOAN t)
        {
            throw new NotImplementedException();
        }
        //Xóa đối tượng t khỏi table
        public bool delete(TAIKHOAN t)
        {
            throw new NotImplementedException();
        }

        //Cập nhật một đối tượng có soDienThoai = t.soDienThoai thành t trong table
        public bool update(TAIKHOAN t) {
            //Lấy đối tượng từ db
            TAIKHOAN update = db.TAIKHOANs.Find(t.soDienThoai);
            //Thay đổi từng thuộc tính của đối tượng, không thể dùng update = t vì địa chỉ trong update bị thay đổi
            //nên không cập nhật được
            update.soDienThoai = t.soDienThoai;
            update.tenNguoiDung = t.tenNguoiDung;
            update.cauHoiBaoMat = t.cauHoiBaoMat;
            update.cauTraLoiBaoMat = t.cauTraLoiBaoMat;
            update.thongBao = t.thongBao;
            update.trangThai = t.trangThai;
            update.matKhau = t.matKhau;
            update.vaiTro = t.vaiTro;
            db.SaveChanges();
            return true;
        }
    }  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Datalayer
{
    public class DMThongBao:IDM<THONGBAO>
    {
        private CINEMA_2Entities db = new CINEMA_2Entities();
        //Tạo phương thức static return class để không cần tạo đối tượng mới mỗi lần chạy
        public static DMThongBao run()
        {
            return new DMThongBao();
        }

        //Lấy tất cả đối tượng trong table
        public List<THONGBAO> selectAll()
        {
            //Lấy theo ngày đăng giảm dần
            return (from c in db.THONGBAOs 
                orderby c.ngayDang descending 
                select c).ToList();
        }

        //Lấy đối tượng theo id t.id
        public THONGBAO selectByID(THONGBAO t)
        {
            throw new NotImplementedException();
        }

        //Thôi vào table một đối tượng
        public bool insert(THONGBAO t)
        {
            throw new NotImplementedException();
        }

        //Xóa đối tượng khỏi table
        public bool delete(THONGBAO t)
        {
            throw new NotImplementedException();
        }
        ////Cập nhật một đối tượng có id = t.id thành t trong table
        public bool update(THONGBAO t)
        {
            throw new NotImplementedException();
        }
    }
}

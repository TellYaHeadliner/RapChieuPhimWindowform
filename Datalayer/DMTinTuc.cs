using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Datalayer
{
    public class DMTinTuc : IDM<TINTUC>
    {
        private CINEMA_2Entities db = new CINEMA_2Entities();
        //Tạo phương thức static return class để không cần tạo đối tượng mới mỗi lần chạy
        public static DMTinTuc run()
        {
            return new DMTinTuc();
        } 
        //Lấy tất cả đối tượng có trong table
        public List<TINTUC> selectAll()
        {
            //Lấy theo ngày tạo giảm dần
            return (from c in db.TINTUCs orderby c.ngayTao select c).ToList();
        }
        //lấy đối tượng theo Duyệt và trạng thái
        public List<TINTUC> selectByDuyetTrangThai(bool daDuyet,bool? trangThai = null)
        {
            //Lấy theo ngày đăng giảm dần
            //Nếu nhập trạng thái sẽ lấy kèm trạng thái
            if(trangThai != null)
                return (from c in db.TINTUCs
                        where c.trangThai == trangThai && c.daDuyet == daDuyet
                        orderby c.ngayTao descending 
                        select c
                        ).ToList();
            //Không nhập sẽ chỉ lấy theo daDuyet
            return (from c in db.TINTUCs
                    where c.daDuyet == daDuyet
                    orderby c.ngayTao descending
                    select c
                ).ToList();
        }
        //Lấy đối tượng theo id t.id
        public TINTUC selectByID(TINTUC t)
        {
            throw new NotImplementedException();
        }
        //Thêm đối tượng t vào table
        public bool insert(TINTUC t)
        {
            throw new NotImplementedException();
        }
        //Xóa đối tượng t khỏi table
        public bool delete(TINTUC t)
        {
            throw new NotImplementedException();
        }
        //Cập nhật một đối tượng có id = t.id thành t trong table
        public bool update(TINTUC t)
        {
            throw new NotImplementedException();
        }
    }
}

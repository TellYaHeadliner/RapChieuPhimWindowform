using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Datalayer
{
    public class DMPhim: IDM<PHIM>
    {
        private CINEMA_2Entities db = new CINEMA_2Entities();
        //Tạo phương thức static return class để không cần tạo đối tượng mới mỗi lần chạy
        public static DMPhim run()
        {
            return new DMPhim();
        }
        //Tìm tất cả phim
        public List<PHIM> selectAll()
        {
            //Lấy theo ngày phát hành giảm dần
            return db.PHIMs.OrderByDescending(p => p.ngayPhatHanh).ToList();
        }
        //Tìm theo lượt xem
        public List<PHIM> selectAllView()
        {
            //Lấy theo lượt xem giảm dần
            return db.PHIMs.OrderByDescending(p => p.luotXem).ToList();
        }

        public PHIM selectByID(PHIM t)
        {
            throw new NotImplementedException();
        }

        public bool insert(PHIM t)
        {
            throw new NotImplementedException();
        }

        public bool delete(PHIM t)
        {
            throw new NotImplementedException();
        }

        public bool update(PHIM t)
        {
            throw new NotImplementedException();
        }
    }
}

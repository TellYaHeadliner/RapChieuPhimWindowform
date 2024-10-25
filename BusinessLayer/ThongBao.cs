using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Model;

namespace BusinessLayer
{
    public class ThongBao
    {
        //Lấy tất cả thông báo
        public static List<THONGBAO> allThongBao()
        {
            return DMThongBao.run().selectAll();
        }
    }
}

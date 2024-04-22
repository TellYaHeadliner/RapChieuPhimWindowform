using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Datalayer;

namespace BusinessLayer
{
    public class TinTuc
    {
        //Lấy tin tức
        public static List<TINTUC> allTinTuc(bool? daDuyet = null,bool? trangThai = null)
        {
            //Nếu nhập đã duyệt thì sẽ tìm theo đã duyệt và trạng thái
            if (daDuyet!=null )
                return DMTinTuc.run().selectByDuyetTrangThai((daDuyet == true ? true : false),trangThai);
            else
                return DMTinTuc.run().selectAll();
        }
        //Lấy tin tức theo ID
        public static TINTUC selectByID(TINTUC tinTuc)
        {
            return DMTinTuc.run().selectByID(tinTuc);
        }
    }
}

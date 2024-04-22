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
        public static bool addTinTuc(string maNV, string tieuDe, string noiDung, string anhTieuDe, string anhNoiDung, bool daDuyet)
        {
            TINTUC tinTuc = new TINTUC() {luotXem=0, ngayTao=DateTime.Now, tieuDe = tieuDe, noiDung=noiDung, anhTieuDe=anhTieuDe, anhNoiDung=anhNoiDung, daDuyet=daDuyet,trangThai=true, maNhanVien=maNV};
            return DMTinTuc.run().insert(tinTuc);
        }
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
    public interface IDM<T>
    {

        //Tất cả thông tin
        List<T> selectAll();

        //Tìm theo ID
        T selectByID(T t);

        //Thêm
        bool insert(T t);

        //Xoá
        bool delete(T t);

        //Sửa
        bool update(T t);
    }
}

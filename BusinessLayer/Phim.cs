using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Model;

namespace BusinessLayer
{
    public class Phim
    {
        public static List<PHIM> selectAll(bool View = false)
        {
            if (View)
                return DMPhim.run().selectAllView();
            return DMPhim.run().selectAll();
        }
    }
}

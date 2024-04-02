using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProjectRapChieuPhim
{
    internal class User
    {
        private string soDienThoai;
        private string matKhau;
        private string TenNguoiDung;
        private int vaiTro;
        private bool trangThai;
        private string connectdb = "Data Source=localhost;Initial Catalog=CINEMA;Integrated Security=True;";

        public User() { }
        public string SoDienThoai {
            get { return soDienThoai; } 
            set { this.soDienThoai = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { this.matKhau = value; }
        }

        public int dangNhap(string SDT, string matKhau)
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectdb))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("dbo.DANGNHAP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    SqlParameter paramSDT = new SqlParameter("@SDT", SqlDbType.Char, 10);
                    paramSDT.Value = SDT;
                    cmd.Parameters.Add(paramSDT);

                    SqlParameter paramMatKhau = new SqlParameter("@matKhau", SqlDbType.Char, 16);
                    paramMatKhau.Value = matKhau;
                    cmd.Parameters.Add(paramMatKhau);

                    count = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
  
            return count;
            
        }

        private void checkAdmin()
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectdb))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("dbo.DANGNHAP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramSDT = new SqlParameter("@SDT", SqlDbType.Char, 10);
                    paramSDT.Value = SDT;
                    cmd.Parameters.Add(paramSDT);

                    SqlParameter paramMatKhau = new SqlParameter("@matKhau", SqlDbType.Char, 16);
                    paramMatKhau.Value = matKhau;
                    cmd.Parameters.Add(paramMatKhau);

                    count = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return count;
        } 
    }
}

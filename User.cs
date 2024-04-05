using System;
using System.Data;
using System.Data.SqlClient;


namespace ProjectRapChieuPhim
{
    internal class User
    {
        protected string soDienThoai;
        protected string matKhau;
        protected string tenNguoiDung;
        protected string connectdb = "Data Source=localhost;Initial Catalog=CINEMA;Integrated Security=True;";

        public User() { }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { this.soDienThoai = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { this.matKhau = value; }
        }

        public string TenNguoiDung {
            get { return tenNguoiDung; }
            set { this.tenNguoiDung = value ; } 
        }

        public int dangNhap(string SDT, string matKhau)
        {
            int vaiTro = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectdb))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("dangNhap", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào stored procedure
                    cmd.Parameters.AddWithValue("@SDT", SDT);
                    cmd.Parameters.AddWithValue("@matKhau", matKhau);

                    // Thêm tham số đầu ra
                    SqlParameter outputVaiTro = new SqlParameter("@vaiTro", SqlDbType.Int);
                    outputVaiTro.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputVaiTro);

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();

                    // Lấy giá trị của biến vaiTro từ tham số đầu ra
                    vaiTro = (int)outputVaiTro.Value;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Console.WriteLine("Lỗi đăng nhập: " + ex.Message);
            }
            return vaiTro;
        }
    }
}

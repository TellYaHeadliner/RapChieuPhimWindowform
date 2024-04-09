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
        protected string cauHoiBaoMat;
        protected string cauTraLoiBaoMat;
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

        public string CauHoiBaoMat {
            get { return cauHoiBaoMat; }
            set { this.cauHoiBaoMat = value; } 
        }

        public string CauTraLoiBaoMat
        {
            get { return cauTraLoiBaoMat; }
            set { this.cauTraLoiBaoMat = value; }
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
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Console.WriteLine("Lỗi đăng nhập: " + ex.Message);
            }
            return vaiTro;
        }

        public bool dangKi()
        {
            using (SqlConnection conn = new SqlConnection(connectdb))
            {
                SqlCommand cmd = new SqlCommand("dangKi", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@soDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);
                cmd.Parameters.AddWithValue("@tenNguoiDung", tenNguoiDung);
                cmd.Parameters.AddWithValue("@cauHoiBaoMat", cauHoiBaoMat);
                cmd.Parameters.AddWithValue("@cauTraLoiBaoMat", cauTraLoiBaoMat);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return false;

        }

        public bool quenMatKhau()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectdb))
                {
                    SqlCommand cmd = new SqlCommand("quenMatKhau_getInformation", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SDT", soDienThoai);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        cauHoiBaoMat = reader.GetString(0);
                        cauTraLoiBaoMat = reader.GetString(1);
                        SoDienThoai = reader.GetString(2);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool updatePassword()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectdb))
                {
                    SqlCommand cmd = new SqlCommand("updateMatKhau", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@matKhauMoi", matKhau);
                    cmd.Parameters.AddWithValue("@SDT", soDienThoai);
                    conn.Open();
                    
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else { return false; }
                    
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
    }
}


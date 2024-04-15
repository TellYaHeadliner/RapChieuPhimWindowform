using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DOANMONHOC
{
    public partial class TrangChu : Form
    {
        //listThongBao bề ngang được 49 ký tự
        private string sdt;
        private bool nhapSearch = false;
        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=CINEMA_2;Integrated Security=True;");
        public TrangChu(string sdt = "0886627561")
        {
            this.sdt = sdt;
            InitializeComponent();
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            quetThongTin();
            nhanTinTuc();
            //tạo một luồng xét thông báo
            Thread iconThongBao = new Thread(changeIconThongBao);
            iconThongBao.IsBackground = true;
            iconThongBao.Start();
            nhanThongBao();
        }

        //Nhan va thay doi thong bao
        private void changeIconThongBao()
        {
            //Liên kết sql
            SqlCommand cmd = new SqlCommand("select thongBao from TAIKHOAN where soDienThoai = '" + sdt + "'", conn);
            SqlDataReader dr;
            DataTable ttThongBao = new DataTable();

            //Lặp lại liên tục để xét có thông báo mới không sẽ hiển thị chuông có chấm đỏ
            while (true)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    dr = cmd.ExecuteReader();
                    ttThongBao = new DataTable();
                    ttThongBao.Load(dr);
                    if (ttThongBao.Rows[0][0].ToString().Trim() == "True")
                    {
                        thongBao.BackgroundImage = Image.FromFile(".\\Pictures\\chuongcothongbao.png");
                        nhanThongBao();
                    }
                }
                catch (Exception ex) { }
                //Đặt thời gian chờ 1 phút
                Thread.Sleep(60000);
            }
            conn.Close();
        }

        //Thêm thông báo vào listbox thông báo
        private void nhanThongBao()
        {
            // Nếu không ở trong luồng giao diện người dùng chính, sử dụng Invoke để gọi lại hàm từ luồng giao diện người dùng chính
            if (listThongBao.InvokeRequired)
            {
                listThongBao.Invoke(new MethodInvoker(delegate { nhanThongBao(); }));
            }
            else
                try
                {
                    //Kết nối sql và lấy dữ liệu trong table thông báo
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand("select ngayDang,thongTin from THONGBAO ORDER BY ngayDang DESC", conn);
                    SqlDataReader dr=cmd.ExecuteReader();
                    DataTable tb = new DataTable();
                    tb.Load(dr);
                    //xóa hết thông báo rồi thêm từng row trong table vào
                    listThongBao.Items.Clear();
                    foreach (DataRow row in tb.Rows)
                    {
                        string date = row[0].ToString().Trim();
                        string thongTin = row[1].ToString().Trim();
                        int flag = 0;
                        listThongBao.Items.Add(date);
                        //cắt chuỗi ra thành từng item nhỏ để không vượt ra ngoài listbox
                        for (int i = 57; i < thongTin.Length; i += 57)
                        {
                            //quay về đúng khoảng trắng để không cắt giữa chữ
                            for (; thongTin[i] != ' '; i--) ;
                            listThongBao.Items.Add(thongTin.Substring(flag, i - flag));
                            flag = i + 1;
                        }
                        listThongBao.Items.Add(thongTin.Substring(flag, thongTin.Length - 1 - flag + 1));
                        listThongBao.Items.Add("------------------------------------------------------------------------");
                    }
                }catch (Exception ex) { }
        }

        //Lấy thông tin về user name để hiển thị trong mục tùy chọn
        private void quetThongTin()
        {
            try {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC dbo.getUserName '" + sdt + "'", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                userName.Text = dt.Rows[0][0].ToString();
                soDT.Text = sdt;
            } catch (Exception e) { }
            conn.Close();
        }

        //Lấy tin tức từ database để hiển thị trong giao diện
        private void nhanTinTuc(string searchh = " ") {
            try
            {
                tinTuc.Controls.Clear();
                //Kết nối lấy tin tức
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from TINTUC", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                //Đặt biến i để phân biệt vị trí của tin tức
                int i = -1;
                //Nhập tin tức vào giao diện
                foreach (DataRow row in dt.Rows)
                {
                    //Nếu searchh tồn tại trong chuỗi không phân biệt chữ hoa chữ thường
                    if (row[1].ToString().IndexOf(searchh, StringComparison.OrdinalIgnoreCase) >= 0 || row[2].ToString().IndexOf(searchh, StringComparison.OrdinalIgnoreCase) >= 0) {
                        i++;
                        //tạo group để chứ thông tin của một tin tức
                        GroupBox rgb = new GroupBox();
                        rgb.Location = new System.Drawing.Point(10, 10 * (i + 1) + 200 * i);
                        rgb.Size = new System.Drawing.Size(940, 200);
                        rgb.Name = "rg/" + row[0].ToString().Trim();
                        //Các thành phần của tin tức
                        Label tieuDe = new Label();
                        Label noiDung = new Label();
                        Label luotXem = new Label();
                        Label tacGia = new Label();
                        Label ngayDang = new Label();
                        PictureBox hAnh = new PictureBox();

                        //Tinh chỉnh vị trí và giá trị thành phần
                        tieuDe.Size = new System.Drawing.Size(700, 55);
                        noiDung.Size = new System.Drawing.Size(700, 40);
                        tacGia.Size = new System.Drawing.Size(700, 20);
                        ngayDang.Size = new System.Drawing.Size(700, 20);
                        luotXem.Size = new System.Drawing.Size(700, 20);
                        hAnh.Size = new System.Drawing.Size(170, 170);

                        tieuDe.Location = new System.Drawing.Point(20, 30);
                        noiDung.Location = new System.Drawing.Point(20, 85);
                        tacGia.Location = new System.Drawing.Point(20, 135);
                        ngayDang.Location = new System.Drawing.Point(20, 155);
                        luotXem.Location = new System.Drawing.Point(20, 175);
                        hAnh.Location = new System.Drawing.Point(740, 20);


                        tieuDe.Font = new Font(tieuDe.Font.FontFamily, 16);
                        tieuDe.Font = new Font(tieuDe.Font, tieuDe.Font.Style | FontStyle.Bold);
                        noiDung.Font = new Font(noiDung.Font.FontFamily, 12);
                        noiDung.ForeColor = Color.Gray;
                        tacGia.Font = new Font(noiDung.Font.FontFamily, 12);
                        tacGia.ForeColor = Color.Gray;
                        ngayDang.Font = new Font(noiDung.Font.FontFamily, 12);
                        ngayDang.ForeColor = Color.Gray;
                        luotXem.Font = new Font(noiDung.Font.FontFamily, 12);
                        luotXem.ForeColor = Color.Gray;

                        tieuDe.Text = row[1].ToString().Trim();
                        //Lấy 150 ký tự đầu của nội dụng
                        noiDung.Text = row[2].ToString().Trim().Substring(0, Math.Min(row[2].ToString().Trim().Length, 150)) + "...";
                        //Lấy tên tác giả
                        DataTable tentacgia = new DataTable();
                        rd = new SqlCommand("EXEC dbo.getUserName '" + row[4].ToString().Trim() + "'", conn).ExecuteReader();
                        tentacgia.Load(rd);
                        tacGia.Text = "By: " + tentacgia.Rows[0][0].ToString().Trim() + ".";
                        ngayDang.Text = "Date: " + (DateTime.Parse(row[3].ToString().Trim())).ToString("dd/MM/yyyy") + ".";
                        luotXem.Text = "Views: " + row[7].ToString().Trim() + ".";
                        //Đặt size cho hình ảnh-> đặt lại size của picturebox -> căn chỉnh picture box nằm giữa theo chiều dọc
                        try
                        {
                            Image img = Image.FromFile(".\\Pictures\\" + row[5].ToString().Trim());
                            Image imgReSize = reSizeImage(img, hAnh.Width, img.Height * hAnh.Width / img.Width);
                            hAnh.Image = imgReSize;
                            hAnh.Size = new Size(imgReSize.Width, imgReSize.Height);
                            hAnh.Location = new System.Drawing.Point(740, rgb.Height - (imgReSize.Height / 2 + imgReSize.Height));
                        }
                        catch (Exception ex) { }

                        //Đưa id bài viết vào name
                        tieuDe.Name = "tD/" + row[0].ToString().Trim();
                        noiDung.Name = "nD/" + row[0].ToString().Trim();
                        tacGia.Name = "tG/" + row[0].ToString().Trim();
                        ngayDang.Name = "dT/" + row[0].ToString().Trim();
                        luotXem.Name = "lX/" + row[0].ToString().Trim();
                        hAnh.Name = "hA/" + row[0].ToString().Trim();

                        //Thêm các thành phần vào group
                        rgb.Controls.Add(tieuDe);
                        rgb.Controls.Add(noiDung);
                        rgb.Controls.Add(tacGia);
                        rgb.Controls.Add(ngayDang);
                        rgb.Controls.Add(luotXem);
                        rgb.Controls.Add(hAnh);

                        //gắn sự kiện khi nhấn vào một tin tức
                        foreach (Control ct in rgb.Controls)
                            ct.Click += groupBox_Click;
                        rgb.Click += groupBox_Click;
                        //Thêm group chứ tin tức mới tạo vào panel trong giao diện
                        tinTuc.Controls.Add(rgb);
                    }
                }
            }
            catch (Exception e) { }
            conn.Close();
        }
        //Đặt lại size của hình ảnh
        private Image reSizeImage(Image image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return result;
        }

        //Nhấn nút tìm kiếm
        private void timKiem_Click(object sender, EventArgs e)
        {
            nhanTinTuc(search.Text);
        }

        //Khi đang nhập người dùng nhấn phím enter
        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                nhanTinTuc(search.Text);
        }

        //Bấm vào tùy chọn để ẩn/hiện bảng tùy chọn
        private void btnTuyChon_Click(object sender, EventArgs e)
        {
                tblTuyChon.Visible = !tblTuyChon.Visible;
        }

        //Bật tắt thông báo và đặt trạng thái thông báo về 0
        private void thongBao_Click(object sender, EventArgs e)
        {
            //Bật tắt thông báo
            listThongBao.Visible = !listThongBao.Visible;
            //Khi thông báo bật lên sẽ đặt trạng thái thông báo của tài khoản thành 0
            if (listThongBao.Visible)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand("update TAIKHOAN set thongBao = 0 where soDienThoai = '" + sdt + "'", conn);
                    thongBao.BackgroundImage = Image.FromFile(".\\Pictures\\chuongkhongthongbao.png");
                    cmd.ExecuteNonQuery();
                }
                catch (Exception err) { }
                conn.Close();
            }
        }

        //Sử lý sự kiện khi người dùng nhấn vào một tin tức
        private void groupBox_Click(object sender, EventArgs e)
        {
            //Lấy id bài viết
            string id = (sender as Control).Name.Split('/')[1];
            // Xử lý logic khi người dùng nhấp vào GroupBox ai làm phần này nhớ cộng lượt xem khi ấn vào
            //lưu ý id người ấn vào trùng với id người đăng sẽ không cộng lượt xem.
            //gợi ý sử dung id trong phương thức này select sdt from TINTUC xem sdt có trùng với biến private string sdt không
            MessageBox.Show("ID tin tức " + id);
        }

        //Nhấn vào nút tài khoản để chuyển trang cài đặt tài khoản
        private void settingTK_Click(object sender, EventArgs e)
        {
            //sdt đã được lưu ở biến private string sdt
        }

        //Đăng xuất
        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }

    }
}

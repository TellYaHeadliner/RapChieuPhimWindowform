using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace RapChieuPhim
{
    public partial class DatVe : Form
    {
        private HOADON hoaDon;
        private string hSearch = "";
        private bool cheDoXem = true;
        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=CINEMA_2;Integrated Security=True;");
        public DatVe(string sdt)
        {
            hoaDon = new HOADON(){soDienThoai = sdt};
            InitializeComponent();
        }
        private void formDatVe_Load(object sender, EventArgs e)
        {
            nhanPhim();
        }
        private void nhanPhim(string searchh = " ", bool stt = true)
        {
            try
            {
                hSearch = searchh;
                tinTuc.Controls.Clear();
                //Đặt biến i để phân biệt vị trí của tin tức
                int i = -1;
                //Nhập tin tức vào giao diện
                foreach (PHIM row in Phim.selectAll(!stt))
                {
                    //Nếu searchh tồn tại trong chuỗi không phân biệt chữ hoa chữ thường
                    if (row.tenPhim.IndexOf(searchh, StringComparison.OrdinalIgnoreCase) >= 0 || row.moTa.IndexOf(searchh, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        i++;
                        //tạo group để chứ thông tin của một tin tức
                        GroupBox rgb = new GroupBox();
                        rgb.Location = new System.Drawing.Point(10, 10 * (i + 1) + 200 * i);
                        rgb.Size = new System.Drawing.Size(940, 200);
                        rgb.Name = "rg/" + row.maPhim;
                        //Các thành phần của tin tức
                        Label tieuDe = new Label();
                        Label noiDung = new Label();
                        Label luotXem = new Label();
                        Label theLoai = new Label();
                        Label ngayDang = new Label();
                        PictureBox hAnh = new PictureBox();

                        //Tinh chỉnh vị trí và giá trị thành phần
                        tieuDe.Size = new System.Drawing.Size(750, 25);
                        noiDung.Size = new System.Drawing.Size(750, 110);
                        theLoai.Size = new System.Drawing.Size(200, 20);
                        ngayDang.Size = new System.Drawing.Size(145, 20);
                        luotXem.Size = new System.Drawing.Size(200, 20);
                        hAnh.Size = new System.Drawing.Size(189, 189);

                        tieuDe.Location = new System.Drawing.Point(180, 30);
                        noiDung.Location = new System.Drawing.Point(180, 60);
                        theLoai.Location = new System.Drawing.Point(180, 175);
                        ngayDang.Location = new System.Drawing.Point(790, 175);
                        luotXem.Location = new System.Drawing.Point(400, 175);
                        hAnh.Location = new System.Drawing.Point(740, 20);


                        tieuDe.Font = new Font(tieuDe.Font.FontFamily, 16);
                        tieuDe.Font = new Font(tieuDe.Font, tieuDe.Font.Style | FontStyle.Bold);
                        noiDung.Font = new Font(noiDung.Font.FontFamily, 11);
                        noiDung.ForeColor = Color.Gray;
                        theLoai.Font = new Font(noiDung.Font.FontFamily, 12);
                        theLoai.ForeColor = Color.Gray;
                        ngayDang.Font = new Font(noiDung.Font.FontFamily, 12);
                        ngayDang.ForeColor = Color.Gray;
                        luotXem.Font = new Font(noiDung.Font.FontFamily, 12);
                        luotXem.ForeColor = Color.Gray;

                        tieuDe.Text = row.tenPhim;
                        //Lấy 150 ký tự đầu của nội dụng
                        noiDung.Text = row.moTa;
                        //Lấy tên thể loại
                        theLoai.Text = "Thể loại: " + row.THELOAIPHIM.theLoaiPhim1;
                        ngayDang.Text = "Date: " + row.ngayPhatHanh.ToString("dd/MM/yyyy") + ".";
                        luotXem.Text = "Views: " + row.luotXem + ".";
                        //Đặt size cho hình ảnh-> đặt lại size của picturebox -> căn chỉnh picture box nằm giữa theo chiều dọc
                        try
                        {
                            Image img = Image.FromFile(".\\Pictures\\" + row.anhBia);
                            Image imgReSize = reSizeImage(img, img.Width * hAnh.Height / img.Height, hAnh.Height);
                            hAnh.Image = imgReSize;
                            hAnh.Size = new Size(imgReSize.Width, imgReSize.Height);
                            hAnh.Location = new System.Drawing.Point(90 - imgReSize.Width / 2, 8);
                        }
                        catch (Exception ex) { }

                        //Đưa id bài viết vào name
                        tieuDe.Name = "tD/" + row.maPhim;
                        noiDung.Name = "nD/" + row.maPhim;
                        theLoai.Name = "tL/" + row.maPhim;
                        ngayDang.Name = "dT/" + row.maPhim;
                        luotXem.Name = "lX/" + row.maPhim;
                        hAnh.Name = "hA/" + row.maPhim;

                        //Thêm các thành phần vào group
                        rgb.Controls.Add(tieuDe);
                        rgb.Controls.Add(noiDung);
                        rgb.Controls.Add(theLoai);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            nhanPhim(search.Text, cheDoXem);
        }
        //Khi đang nhập người dùng nhấn phím enter
        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                nhanPhim(search.Text, cheDoXem);
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

        private void butCheDo_Click(object sender, EventArgs e)
        {
            cheDoXem = !cheDoXem;
            if (!cheDoXem)
                butCheDo.Text = "Xem phim mới nhất";
            else
                butCheDo.Text = "Xếp theo độ HOT";
            nhanPhim(hSearch, cheDoXem);
        }
    }
}

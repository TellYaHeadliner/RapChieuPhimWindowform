using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim
{
    public partial class frmTinDaDang : Form
    {
        private NHANVIEN nv;
        public frmTinDaDang(NHANVIEN nv)
        {
            this.nv = nv;
            InitializeComponent();
        }
        //Lấy tin tức từ database để hiển thị trong giao diện
        private void nhanTinTuc(string searchh = " ")
        {
            tinTuc.Controls.Clear();
            //Đặt biến i để phân biệt vị trí của tin tức
            int i = -1;
            //Nhập tin tức vào giao diện
            foreach (TINTUC row in TinTuc.tinDaDang(nv.maNhanVien))
            {
                //Nếu searchh tồn tại trong chuỗi không phân biệt chữ hoa chữ thường
                if (row.noiDung.IndexOf(searchh, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    i++;
                    //tạo group để chứ thông tin của một tin tức
                    GroupBox rgb = new GroupBox();
                    rgb.Location = new System.Drawing.Point(10, 10 * (i + 1) + 200 * i);
                    rgb.Size = new System.Drawing.Size(940, 200);
                    rgb.Name = "rg/" + row.id.ToString();
                    //Các thành phần của tin tức
                    Button edit = new Button();
                    Label tieuDe = new Label();
                    Label noiDung = new Label();
                    Label luotXem = new Label();
                    Label tacGia = new Label();
                    Label ngayDang = new Label();
                    PictureBox hAnh = new PictureBox();
                    

                    //Tinh chỉnh vị trí và giá trị thành phần
                    tieuDe.Size = new System.Drawing.Size(700, 55);
                    noiDung.Size = new System.Drawing.Size(500, 40);
                    tacGia.Size = new System.Drawing.Size(500, 20);
                    ngayDang.Size = new System.Drawing.Size(500, 20);
                    luotXem.Size = new System.Drawing.Size(500, 20);
                    hAnh.Size = new System.Drawing.Size(200, 170);
                    edit.Size = new System.Drawing.Size(50,40);

                    tieuDe.Location = new System.Drawing.Point(20, 30);
                    noiDung.Location = new System.Drawing.Point(20, 85);
                    tacGia.Location = new System.Drawing.Point(20, 135);
                    ngayDang.Location = new System.Drawing.Point(20, 155);
                    luotXem.Location = new System.Drawing.Point(20, 175);
                    hAnh.Location = new System.Drawing.Point(725, 17);
                    edit.Location = new System.Drawing.Point(650, 150);


                    tieuDe.Font = new Font(tieuDe.Font.FontFamily, 16);
                    tieuDe.Font = new Font(tieuDe.Font, tieuDe.Font.Style | FontStyle.Bold);
                    noiDung.Font = new Font(noiDung.Font.FontFamily, 12);
                    noiDung.ForeColor = Color.Gray;
                    tacGia.Font = new Font(tacGia.Font.FontFamily, 12);
                    tacGia.ForeColor = Color.Gray;
                    ngayDang.Font = new Font(ngayDang.Font.FontFamily, 12);
                    ngayDang.ForeColor = Color.Gray;
                    luotXem.Font = new Font(luotXem.Font.FontFamily, 12);
                    luotXem.ForeColor = Color.Gray;
                    tieuDe.Text = row.tieuDe;
                    edit.Font = new Font(edit.Font.FontFamily, 10);
                    edit.ForeColor = Color.Gray;
                    //Lấy 150 ký tự đầu của nội dụng
                    noiDung.Text = row.noiDung.Substring(0, Math.Min(row.noiDung.Length, 150)) + "...";
                    tacGia.Text = "By: " + row.TAIKHOAN.tenNguoiDung;
                    ngayDang.Text = "Date: " + row.ngayTao.Value.ToString("MM/dd/yyyy") + ".";
                    luotXem.Text = "Views: " + row.luotXem.ToString().Trim() + ".";
                    hAnh.Image = Image.FromFile(".\\Pictures\\" + row.anhTieuDe);
                    hAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    edit.Text = "Edit";

                    //Đưa id bài viết vào name
                    tieuDe.Name = "tD/" + row.id;
                    noiDung.Name = "nD/" + row.id;
                    tacGia.Name = "tG/" + row.id;
                    ngayDang.Name = "dT/" + row.id;
                    luotXem.Name = "lX/" + row.id;
                    hAnh.Name = "hA/" + row.id;
                    edit.Name = "eD/" + row.id;

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

                    rgb.Controls.Add(edit);
                    edit.Click +=  controlEdit;

                    //Thêm group chứ tin tức mới tạo vào panel trong giao diện
                    tinTuc.Controls.Add(rgb);
                }
            }
        }
        //control edit 
        private void controlEdit(object sender, EventArgs e)
        {
            string id = (sender as Control).Name.Split('/')[1];
            FrmEditTinTuc st = new FrmEditTinTuc(id);
            this.Hide();
            st.ShowDialog();
            this.Show();
            nhanTinTuc();
        }

        //Sử lý sự kiện khi người dùng nhấn vào một tin tức
        private void groupBox_Click(object sender, EventArgs e)
        {
            //Lấy id bài viết
            string id = (sender as Control).Name.Split('/')[1];
            // Xử lý logic khi người dùng nhấp vào GroupBox ai làm phần này nhớ cộng lượt xem khi ấn vào
            //lưu ý id người ấn vào trùng với id người đăng sẽ không cộng lượt xem.
            //gợi ý sử dung id trong phương thức này select sdt from TINTUC xem sdt có trùng với biến private string sdt không
            XemTinTuc xt = new XemTinTuc(new TINTUC() { id = int.Parse(id) });
            this.Hide();
            xt.ShowDialog();
            this.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            nhanTinTuc(search.Text);
        }
        //Khi đang nhập người dùng nhấn phím enter
        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                nhanTinTuc(search.Text);
        }

        private void frmTinDaDang_Load(object sender, EventArgs e)
        {
            nhanTinTuc();
        }
    }
}

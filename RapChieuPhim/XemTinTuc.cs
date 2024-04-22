using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Model;
using Label = System.Windows.Forms.Label;

namespace RapChieuPhim
{
    public partial class XemTinTuc : Form
    {
        private TINTUC tinTuc;
        public XemTinTuc(TINTUC tinTuc)
        {
            InitializeComponent();
            this.tinTuc = TinTuc.selectByID(tinTuc);
        }

        private void XemTInTuc_Load(object sender, EventArgs e)
        {
            Label tieuDe = new Label();
            PictureBox hAnh = new PictureBox();
            Label noiDung = new Label();
            Label tacGia = new Label();
            Label ngayDang = new Label();
            Label luotXem = new Label();

            tieuDe.Text = tinTuc.tieuDe;
            hAnh.Image = Image.FromFile(".\\Pictures\\"+tinTuc.anhNoiDung);
            hAnh.SizeMode = PictureBoxSizeMode.Zoom;
            noiDung.Text = tinTuc.noiDung;
            tacGia.Text = "By: " + tinTuc.TAIKHOAN.tenNguoiDung;
            ngayDang.Text = "Date: " + tinTuc.ngayTao.Value.ToString("dd/MM/yyyy");
            luotXem.Text = "View: " + tinTuc.luotXem;

            tieuDe.Font = new Font(tieuDe.Font.FontFamily, 30);
            tieuDe.Font = new Font(tieuDe.Font, tieuDe.Font.Style | FontStyle.Bold);
            noiDung.Font = new Font(noiDung.Font.FontFamily, 16);
            tacGia.Font = new Font(tacGia.Font.FontFamily, 12);
            tacGia.ForeColor = Color.Gray;
            ngayDang.Font = new Font(ngayDang.Font.FontFamily, 12);
            ngayDang.ForeColor = Color.Gray;
            luotXem.Font = new Font(luotXem.Font.FontFamily, 12);
            luotXem.ForeColor = Color.Gray;

            tieuDe.Width = 940;
            //Tính toán chiều cao của tiêu đề
            SizeF sizeTieuDe;
            using (Graphics graphics = CreateGraphics()) {
                sizeTieuDe = graphics.MeasureString(tieuDe.Text, tieuDe.Font, tieuDe.Width);
            }
            // Đặt kích thước chiều dọc của tiêu đề dựa trên chiều cao tính toán
            tieuDe.Height = (int)Math.Ceiling(sizeTieuDe.Height) * 110 / 100;
            hAnh.Size = new Size(700, 400);
            noiDung.Width = 940;
            //Tính toán chiều cao của nội dung
            SizeF sizeNoiDung;
            using (Graphics graphics = CreateGraphics()) {
                sizeNoiDung = graphics.MeasureString(noiDung.Text, noiDung.Font, noiDung.Width);
            }
            // Đặt kích thước chiều dọc của nội dung dựa trên chiều cao tính toán
            noiDung.Height = (int)Math.Ceiling(sizeNoiDung.Height)*110/100;
            tacGia.Size = new Size(300, 23);
            ngayDang.Size = new Size(180, 23);
            luotXem.Size = new Size(180, 23);

            hAnh.Location = new Point(pnXemTin.Width/2 - hAnh.Width/2, 10);
            tieuDe.Location = new Point(5, hAnh.Location.Y + hAnh.Height + 10);
            noiDung.Location = new Point(5, tieuDe.Location.Y + tieuDe.Height);
            tacGia.Location = new Point(5, noiDung.Location.Y + noiDung.Height);
            ngayDang.Location = new Point(5, tacGia.Location.Y + tacGia.Height);
            luotXem.Location = new Point(5, ngayDang.Location.Y + ngayDang.Height);

            pnXemTin.Controls.Add(tieuDe);
            pnXemTin.Controls.Add(ngayDang);
            pnXemTin.Controls.Add(hAnh);
            pnXemTin.Controls.Add(tacGia);
            pnXemTin.Controls.Add(noiDung);
            pnXemTin.Controls.Add(luotXem);

        }
    }
}

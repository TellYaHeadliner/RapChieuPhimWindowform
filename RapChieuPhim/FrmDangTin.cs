using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RapChieuPhim
{
    public partial class FrmDangTin : Form
    {
        private NHANVIEN nv;
        public FrmDangTin(NHANVIEN nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        private void btnPathTitle_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileTillte = new OpenFileDialog();
            if (fileTillte.ShowDialog()==DialogResult.OK)
            {
                ptrTieuDe.Image=new Bitmap(fileTillte.FileName);
                txbDuongDanTD.Text=fileTillte.FileName;
            }
        }

        private void btnPathContent_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileContent = new OpenFileDialog();
            if (fileContent.ShowDialog() == DialogResult.OK)
            {
                ptrNoiDung.Image = new Bitmap(fileContent.FileName);
                txbDuongDanND.Text = fileContent.FileName;
            }
        }

        private void bntDang_Click(object sender, EventArgs e)
        {
            String inputTD = txbDuongDanTD.Text;
            //tim vi tri dau gach cheo cuoi cung
            int lastIndexTD = inputTD.LastIndexOf('\\');
            string fileNameTD=inputTD.Substring(lastIndexTD+1);

            //cat chuoi anh noi dung
            String inputND = txbDuongDanTD.Text;
            //tim vi tri dau gach cheo cuoi cung
            int lastIndexND = inputND.LastIndexOf('\\');
            string fileNameND = inputND.Substring(lastIndexND + 1);
            if (txbTieuDe.Text.Trim() == "" || txbContent.Text.Trim() == ""|| ptrTieuDe.Image==null ||ptrNoiDung.Image==null)
            {
                MessageBox.Show("Hình ảnh tiêu đề hoặc tiêu đề hoặc ảnh nội dung hoặc nội dung không được rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (TinTuc.addTinTuc(nv.maNhanVien, txbTieuDe.Text, txbContent.Text, fileNameTD, fileNameND, nv.kiemDuyet))
            {
                File.Copy(inputTD, ".\\Pictures\\"+fileNameTD,true);
                File.Copy(inputND, ".\\Pictures\\"+fileNameND,true);
                this.Close();
            }
            else
                MessageBox.Show("Đã có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            TINTUC tintuc = new TINTUC() { tieuDe = txbTieuDe.Text, noiDung = txbContent.Text };
            frmXemTruoc frmXemTruoc = new frmXemTruoc(tintuc);
            this.Hide();
            frmXemTruoc.ShowDialog();
            this.Show();

        }
    }
}

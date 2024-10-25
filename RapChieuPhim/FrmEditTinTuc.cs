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
    public partial class FrmEditTinTuc : Form
    {
        TINTUC tinTuc;
        public FrmEditTinTuc(string id)
        {
            this.tinTuc = TinTuc.selectByID(new TINTUC() { id = int.Parse(id) }) ;
            InitializeComponent();
        }

        private void FrmEditTinTuc_Load(object sender, EventArgs e)
        {
            txbDuongDanTD.Text = tinTuc.anhTieuDe;
            txbDuongDanND.Text = tinTuc.anhNoiDung;
            txbTieuDe.Text = tinTuc.tieuDe;
            txbContent.Text = tinTuc.noiDung;
            ptrTieuDe.Image = new Bitmap("./Pictures/" + tinTuc.anhTieuDe);
            ptrNoiDung.Image = new Bitmap("./Pictures/" + tinTuc.anhNoiDung);

        }
        private void btnPathTitle_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileTillte = new OpenFileDialog();
            if (fileTillte.ShowDialog() == DialogResult.OK)
            {
                ptrTieuDe.Image = new Bitmap(fileTillte.FileName);
                txbDuongDanTD.Text = fileTillte.FileName;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String inputTD="";
            string fileNameTD="";
            String inputND="";
            string fileNameND="";
            bool cTieuDe = false;
            bool cNoiDung = false;
            try
            {
                inputTD = txbDuongDanTD.Text;
                //tim vi tri dau gach cheo cuoi cung
                int lastIndexTD = inputTD.LastIndexOf('\\');
                fileNameTD = inputTD.Substring(lastIndexTD + 1);
                tinTuc.anhTieuDe = fileNameTD;
                cTieuDe = true;
            }
            catch{ };
            try
            {
                //cat chuoi anh noi dung
                inputND = txbDuongDanTD.Text;
                //tim vi tri dau gach cheo cuoi cung
                int lastIndexND = inputND.LastIndexOf('\\');
                fileNameND = inputND.Substring(lastIndexND + 1);
                tinTuc.anhNoiDung = fileNameND;
                cNoiDung=true;
            }catch{ };
            if (txbTieuDe.Text.Trim() == "" || txbContent.Text.Trim() == "" || ptrTieuDe.Image == null || ptrNoiDung.Image == null)
            {
                MessageBox.Show("Hình ảnh tiêu đề hoặc tiêu đề, ảnh nội dung hoặc nội dung không được rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tinTuc.tieuDe=txbTieuDe.Text.Trim();
                tinTuc.noiDung=txbContent.Text.Trim();
                if (TinTuc.editTinTuc(tinTuc))
                {
                    if(cTieuDe)
                        File.Copy(inputTD, ".\\Pictures\\" + fileNameTD, true);
                    if(cNoiDung)
                        File.Copy(inputND, ".\\Pictures\\" + fileNameND, true);
                    this.Close();
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

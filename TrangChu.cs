using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANMONHOC
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                GroupBox rgb = new GroupBox();
                rgb.Location = new System.Drawing.Point(10, 10*(i+1)+200*i);
                rgb.Size = new System.Drawing.Size(940, 200);
                rgb.Name = "rg/" + i;

                Label label1 = new Label();
                Label label2 = new Label();
                label1.Size = new System.Drawing.Size(200, 25);
                label2.Size = new System.Drawing.Size(200, 25);
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Bold);
                label1.Font = new Font(label1.Font.FontFamily, 16);
                label1.Text = "Lable"+i+" aaaa";
                label2.Text = "Lable"+i+" bbbb";
                label1.Location = new System.Drawing.Point(20, 30);
                label2.Location = new System.Drawing.Point(20, 70);
                label1.Name = "l1/" + i;
                label2.Name = "l2/" + i;
                
                rgb.Controls.Add(label1);
                rgb.Controls.Add(label2);
                foreach (Control ct in rgb.Controls)
                    ct.Click +=  GroupBox_Click;
                rgb.Click +=  GroupBox_Click;

                tinTuc.Controls.Add(rgb);
            }
        }
        private void GroupBox_Click(object sender, EventArgs e)
        {
            Control ct = sender as Control;
            // Xử lý logic khi người dùng nhấp vào GroupBox
            MessageBox.Show("Bạn đã nhấp vào GroupBox! "+ ct.Name.Split('/')[1]);
        }
        private void timKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnTuyChon_Click(object sender, EventArgs e)
        {
                tblTuyChon.Visible = !tblTuyChon.Visible;
        }
    }
}

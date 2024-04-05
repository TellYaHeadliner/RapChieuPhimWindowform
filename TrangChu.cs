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

namespace DOANMONHOC
{
    public partial class TrangChu : Form
    {
        private string sdt;
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
        }

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

        private void nhanTinTuc(){
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from TINTUC", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                //Nhap tin tuc vao giao dien
                int i = -1;
                foreach (DataRow row in dt.Rows)
                {
                    i++;
                    GroupBox rgb = new GroupBox();
                    rgb.Location = new System.Drawing.Point(10, 10 * (i + 1) + 200 * i);
                    rgb.Size = new System.Drawing.Size(940, 200);
                    rgb.Name = "rg/" + row[0].ToString().Trim();

                    Label label1 = new Label();
                    Label label2 = new Label();
                    label1.Size = new System.Drawing.Size(700, 55);
                    label2.Size = new System.Drawing.Size(700, 50);
                    label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Bold);
                    label1.Font = new Font(label1.Font.FontFamily, 16);
                    label2.Font = new Font(label2.Font.FontFamily, 12);
                    label1.Text = row[1].ToString().Trim();
                    label2.Text = row[2].ToString().Trim().Substring(0, Math.Min(row[2].ToString().Trim().Length, 100))+"...";
                    label1.Location = new System.Drawing.Point(20, 30);
                    label2.Location = new System.Drawing.Point(20, 85);
                    label1.Name = "l1/" + row[0].ToString().Trim();
                    label2.Name = "l2/" + row[0].ToString().Trim();

                    rgb.Controls.Add(label1);
                    rgb.Controls.Add(label2);
                    foreach (Control ct in rgb.Controls)
                        ct.Click += groupBox_Click;
                    rgb.Click += groupBox_Click;

                    tinTuc.Controls.Add(rgb);
                }
            }
            catch (Exception e) { }
            conn.Close();
        }

        private void groupBox_Click(object sender, EventArgs e)
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

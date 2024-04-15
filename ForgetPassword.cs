using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRapChieuPhim
{
    public partial class ForgetPassword : Form
    {   
        public ForgetPassword()
        {
            
            InitializeComponent();
        }

        private void txtBoxSubmit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.SoDienThoai = txtBoxSDT.Text;
            if (user.quenMatKhau() == true)
            {
                Answer answer = new Answer(user.SoDienThoai, user.CauHoiBaoMat, user.CauTraLoiBaoMat);
                answer.Show();
            }
            else
            {
                MessageBox.Show("Số diện thoại không tồn tại");
            }
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}

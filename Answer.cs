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
    public partial class Answer : Form
    {
        private string SDT;
        private string cauHoiBaoMat;
        private string cauTraLoiBaoMat;
        public Answer(string SDT, string cauHoiBaoMat, string cauTraLoiBaoMat)
        {
            this.SDT = SDT;
            this.cauHoiBaoMat = cauHoiBaoMat;
            this.cauTraLoiBaoMat = cauTraLoiBaoMat;
            InitializeComponent();
        }

        private void Answer_Load(object sender, EventArgs e)
        {
            lblYourSDT.Text =  $"Số điện thoại của bạn là: {SDT}";
            txtBoxCauHoiBaoMat.Text =  cauHoiBaoMat;
            txtBoxCauHoiBaoMat.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxCauTraLoiBaoMat.Text == this.cauTraLoiBaoMat)
            {
                UpdatePassword updatePassword = new UpdatePassword(SDT);
                updatePassword.ShowDialog();
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
}

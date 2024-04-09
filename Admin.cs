using System;
using System.Windows.Forms;

namespace ProjectRapChieuPhim
{
    public partial class Admin : Form
    {
        string sdt;
        public Admin(string sdt)
        {
            InitializeComponent();
            this.sdt = sdt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = sdt;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

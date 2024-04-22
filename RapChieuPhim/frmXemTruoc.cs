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

namespace RapChieuPhim
{
    public partial class frmXemTruoc : Form
    {
        TINTUC tinTuc;
        public frmXemTruoc(TINTUC tinTuc)
        {
            this.tinTuc = tinTuc;
            InitializeComponent();
        }

        
private void frmXemTruoc_Load(object sender, EventArgs e)
        {
            label1.Text = tinTuc.tieuDe;
            textBox2.Text = tinTuc.noiDung;

        }
    }
}

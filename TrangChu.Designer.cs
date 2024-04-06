using System.Drawing;
using System.Windows.Forms;

namespace DOANMONHOC
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.search = new System.Windows.Forms.TextBox();
            this.tblTuyChon = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.settingTK = new System.Windows.Forms.Button();
            this.soDT = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tinTuc = new System.Windows.Forms.Panel();
            this.thongBao = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTuyChon = new System.Windows.Forms.Button();
            this.tblTuyChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(62, 18);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(867, 31);
            this.search.TabIndex = 1;
            this.search.Tag = "";
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // tblTuyChon
            // 
            this.tblTuyChon.Controls.Add(this.button2);
            this.tblTuyChon.Controls.Add(this.settingTK);
            this.tblTuyChon.Controls.Add(this.soDT);
            this.tblTuyChon.Controls.Add(this.userName);
            this.tblTuyChon.Location = new System.Drawing.Point(12, 62);
            this.tblTuyChon.Name = "tblTuyChon";
            this.tblTuyChon.Size = new System.Drawing.Size(220, 178);
            this.tblTuyChon.TabIndex = 3;
            this.tblTuyChon.TabStop = false;
            this.tblTuyChon.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(46, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Đăng xuất";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // settingTK
            // 
            this.settingTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingTK.Location = new System.Drawing.Point(46, 74);
            this.settingTK.Name = "settingTK";
            this.settingTK.Size = new System.Drawing.Size(128, 31);
            this.settingTK.TabIndex = 2;
            this.settingTK.Text = "Tài khoản";
            this.settingTK.UseVisualStyleBackColor = true;
            this.settingTK.Click += new System.EventHandler(this.settingTK_Click);
            // 
            // soDT
            // 
            this.soDT.AutoSize = true;
            this.soDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soDT.Location = new System.Drawing.Point(10, 39);
            this.soDT.Name = "soDT";
            this.soDT.Size = new System.Drawing.Size(36, 17);
            this.soDT.TabIndex = 1;
            this.soDT.Text = "SĐT";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(9, 16);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(98, 20);
            this.userName.TabIndex = 0;
            this.userName.Text = "User Name";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(519, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Hàng button này mọi người tùy chỉnh theo chức năng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tinTuc
            // 
            this.tinTuc.AutoScroll = true;
            this.tinTuc.Location = new System.Drawing.Point(12, 101);
            this.tinTuc.Name = "tinTuc";
            this.tinTuc.Size = new System.Drawing.Size(967, 436);
            this.tinTuc.TabIndex = 6;
            // 
            // thongBao
            // 
            this.thongBao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.thongBao.BackgroundImage = global::DOANMONHOC.Properties.Resources.chuongcothongbao;
            this.thongBao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongBao.Location = new System.Drawing.Point(940, 60);
            this.thongBao.Name = "thongBao";
            this.thongBao.Size = new System.Drawing.Size(35, 35);
            this.thongBao.TabIndex = 7;
            this.thongBao.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.BackgroundImage = global::DOANMONHOC.Properties.Resources.kinhlup;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(935, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.timKiem_Click);
            // 
            // btnTuyChon
            // 
            this.btnTuyChon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTuyChon.BackgroundImage = global::DOANMONHOC.Properties.Resources.bieutuong3soctuychon;
            this.btnTuyChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTuyChon.Location = new System.Drawing.Point(12, 12);
            this.btnTuyChon.Name = "btnTuyChon";
            this.btnTuyChon.Size = new System.Drawing.Size(44, 44);
            this.btnTuyChon.TabIndex = 0;
            this.btnTuyChon.UseVisualStyleBackColor = false;
            this.btnTuyChon.Click += new System.EventHandler(this.btnTuyChon_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 549);
            this.Controls.Add(this.thongBao);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tblTuyChon);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnTuyChon);
            this.Controls.Add(this.tinTuc);
            this.Name = "TrangChu";
            this.Text = "TRANG CHỦ";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.tblTuyChon.ResumeLayout(false);
            this.tblTuyChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTuyChon;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox tblTuyChon;
        private System.Windows.Forms.Label soDT;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button settingTK;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel tinTuc;
        private System.Windows.Forms.Button thongBao;
    }
}


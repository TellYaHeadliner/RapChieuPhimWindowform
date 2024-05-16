namespace RapChieuPhim
{
    partial class FrmHienThiThTinKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labSDT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labVaiTro = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.changePass1 = new RapChieuPhim.ChangePass();
            this.reName = new RapChieuPhim.ReName();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "user name: ";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(222, 40);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(79, 29);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "số điện thoại:";
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSDT.Location = new System.Drawing.Point(231, 91);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(79, 29);
            this.labSDT.TabIndex = 3;
            this.labSDT.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "vai trò:";
            // 
            // labVaiTro
            // 
            this.labVaiTro.AutoSize = true;
            this.labVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVaiTro.Location = new System.Drawing.Point(176, 140);
            this.labVaiTro.Name = "labVaiTro";
            this.labVaiTro.Size = new System.Drawing.Size(79, 29);
            this.labVaiTro.TabIndex = 5;
            this.labVaiTro.Text = "label6";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(60, 220);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(124, 46);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(337, 220);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(124, 46);
            this.btnChangePass.TabIndex = 8;
            this.btnChangePass.Text = "Change PassWord";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // changePass1
            // 
            this.changePass1.Location = new System.Drawing.Point(60, 289);
            this.changePass1.Name = "changePass1";
            this.changePass1.Size = new System.Drawing.Size(456, 231);
            this.changePass1.TabIndex = 9;
            this.changePass1.saveChange += new RapChieuPhim.ChangePass.SaveChange(this.reName_saveChange);
            // 
            // reName
            // 
            this.reName.Location = new System.Drawing.Point(60, 289);
            this.reName.Name = "reName";
            this.reName.Size = new System.Drawing.Size(456, 137);
            this.reName.TabIndex = 6;
            this.reName.saveChange += new RapChieuPhim.ReName.SaveChange(this.reName_saveChange);
            // 
            // FrmHienThiThTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 549);
            this.Controls.Add(this.changePass1);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.reName);
            this.Controls.Add(this.labVaiTro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labSDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.label1);
            this.Name = "FrmHienThiThTinKhachHang";
            this.Text = "FrmHienThiThTinKhachHang";
            this.Load += new System.EventHandler(this.FrmHienThiThTinKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labVaiTro;
        private ReName reName;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnChangePass;
        private ChangePass changePass1;
    }
}
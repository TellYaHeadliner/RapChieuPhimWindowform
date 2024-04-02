namespace ProjectRapChieuPhim
{
    partial class Login
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxSDT = new System.Windows.Forms.TextBox();
            this.txtBoxMatKhau = new System.Windows.Forms.TextBox();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.linkLabelForgetPass = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(214, 18);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(412, 73);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "ĐĂNG NHẬP";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(14, 107);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(93, 42);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "SĐT";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 170);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(199, 51);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtBoxSDT
            // 
            this.txtBoxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSDT.Location = new System.Drawing.Point(208, 104);
            this.txtBoxSDT.Name = "txtBoxSDT";
            this.txtBoxSDT.Size = new System.Drawing.Size(630, 49);
            this.txtBoxSDT.TabIndex = 3;
            // 
            // txtBoxMatKhau
            // 
            this.txtBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMatKhau.Location = new System.Drawing.Point(208, 172);
            this.txtBoxMatKhau.Name = "txtBoxMatKhau";
            this.txtBoxMatKhau.Size = new System.Drawing.Size(630, 49);
            this.txtBoxMatKhau.TabIndex = 4;
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSignUp.Location = new System.Drawing.Point(14, 234);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(318, 42);
            this.linkLabelSignUp.TabIndex = 5;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "Đăng ký tài khoản";
            // 
            // linkLabelForgetPass
            // 
            this.linkLabelForgetPass.AutoSize = true;
            this.linkLabelForgetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgetPass.Location = new System.Drawing.Point(581, 234);
            this.linkLabelForgetPass.Name = "linkLabelForgetPass";
            this.linkLabelForgetPass.Size = new System.Drawing.Size(273, 42);
            this.linkLabelForgetPass.TabIndex = 6;
            this.linkLabelForgetPass.TabStop = true;
            this.linkLabelForgetPass.Text = "Quên mật khẩu";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(208, 301);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(523, 86);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(214)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.linkLabelForgetPass);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.txtBoxMatKhau);
            this.Controls.Add(this.txtBoxSDT);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblHeading);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxSDT;
        private System.Windows.Forms.TextBox txtBoxMatKhau;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.LinkLabel linkLabelForgetPass;
        private System.Windows.Forms.Button btnDangNhap;
    }
}
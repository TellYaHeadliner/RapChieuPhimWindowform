namespace ProjectRapChieuPhim
{
    partial class UpdatePassword
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
            this.lblUpdatePassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtBoxUpdatePassword = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật mật khẩu";
            // 
            // lblUpdatePassword
            // 
            this.lblUpdatePassword.AutoSize = true;
            this.lblUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePassword.Location = new System.Drawing.Point(12, 52);
            this.lblUpdatePassword.Name = "lblUpdatePassword";
            this.lblUpdatePassword.Size = new System.Drawing.Size(193, 25);
            this.lblUpdatePassword.TabIndex = 1;
            this.lblUpdatePassword.Text = "Cập nhật mật khẩu";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(12, 87);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(197, 25);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // txtBoxUpdatePassword
            // 
            this.txtBoxUpdatePassword.Location = new System.Drawing.Point(211, 52);
            this.txtBoxUpdatePassword.Name = "txtBoxUpdatePassword";
            this.txtBoxUpdatePassword.Size = new System.Drawing.Size(245, 20);
            this.txtBoxUpdatePassword.TabIndex = 3;
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(211, 92);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(245, 20);
            this.txtBoxConfirmPassword.TabIndex = 4;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(144, 131);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(176, 54);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 200);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtBoxConfirmPassword);
            this.Controls.Add(this.txtBoxUpdatePassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblUpdatePassword);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePassword";
            this.Text = "UpdatePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpdatePassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtBoxUpdatePassword;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.Button btnXacNhan;
    }
}
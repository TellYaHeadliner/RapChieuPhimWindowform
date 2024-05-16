namespace RapChieuPhim
{
    partial class ChangePass
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPassHienTai = new System.Windows.Forms.TextBox();
            this.txbPassMoi = new System.Windows.Forms.TextBox();
            this.txbNhapLaiPass = new System.Windows.Forms.TextBox();
            this.btnHuyPass = new System.Windows.Forms.Button();
            this.btnSavePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // txbPassHienTai
            // 
            this.txbPassHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassHienTai.Location = new System.Drawing.Point(209, 22);
            this.txbPassHienTai.Name = "txbPassHienTai";
            this.txbPassHienTai.PasswordChar = '*';
            this.txbPassHienTai.Size = new System.Drawing.Size(185, 26);
            this.txbPassHienTai.TabIndex = 3;
            // 
            // txbPassMoi
            // 
            this.txbPassMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassMoi.Location = new System.Drawing.Point(209, 61);
            this.txbPassMoi.Name = "txbPassMoi";
            this.txbPassMoi.PasswordChar = '*';
            this.txbPassMoi.Size = new System.Drawing.Size(185, 26);
            this.txbPassMoi.TabIndex = 4;
            // 
            // txbNhapLaiPass
            // 
            this.txbNhapLaiPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNhapLaiPass.Location = new System.Drawing.Point(209, 100);
            this.txbNhapLaiPass.Name = "txbNhapLaiPass";
            this.txbNhapLaiPass.PasswordChar = '*';
            this.txbNhapLaiPass.Size = new System.Drawing.Size(185, 26);
            this.txbNhapLaiPass.TabIndex = 5;
            // 
            // btnHuyPass
            // 
            this.btnHuyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPass.Location = new System.Drawing.Point(209, 145);
            this.btnHuyPass.Name = "btnHuyPass";
            this.btnHuyPass.Size = new System.Drawing.Size(75, 31);
            this.btnHuyPass.TabIndex = 6;
            this.btnHuyPass.Text = "Hủy";
            this.btnHuyPass.UseVisualStyleBackColor = true;
            this.btnHuyPass.Click += new System.EventHandler(this.btnHuyPass_Click);
            // 
            // btnSavePass
            // 
            this.btnSavePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePass.Location = new System.Drawing.Point(319, 145);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(75, 31);
            this.btnSavePass.TabIndex = 7;
            this.btnSavePass.Text = "Save";
            this.btnSavePass.UseVisualStyleBackColor = true;
            this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSavePass);
            this.Controls.Add(this.btnHuyPass);
            this.Controls.Add(this.txbNhapLaiPass);
            this.Controls.Add(this.txbPassMoi);
            this.Controls.Add(this.txbPassHienTai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePass";
            this.Size = new System.Drawing.Size(456, 189);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPassHienTai;
        private System.Windows.Forms.TextBox txbPassMoi;
        private System.Windows.Forms.TextBox txbNhapLaiPass;
        private System.Windows.Forms.Button btnHuyPass;
        private System.Windows.Forms.Button btnSavePass;
    }
}

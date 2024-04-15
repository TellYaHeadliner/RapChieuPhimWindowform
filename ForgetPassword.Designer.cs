namespace ProjectRapChieuPhim
{
    partial class ForgetPassword
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
            this.txtBoxSDT = new System.Windows.Forms.TextBox();
            this.txtBoxSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(90, 6);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(214, 33);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Quên mật khẩu";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(11, 44);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(70, 13);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // txtBoxSDT
            // 
            this.txtBoxSDT.Location = new System.Drawing.Point(96, 41);
            this.txtBoxSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSDT.Name = "txtBoxSDT";
            this.txtBoxSDT.Size = new System.Drawing.Size(223, 20);
            this.txtBoxSDT.TabIndex = 2;
            // 
            // txtBoxSubmit
            // 
            this.txtBoxSubmit.Location = new System.Drawing.Point(138, 65);
            this.txtBoxSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSubmit.Name = "txtBoxSubmit";
            this.txtBoxSubmit.Size = new System.Drawing.Size(102, 30);
            this.txtBoxSubmit.TabIndex = 3;
            this.txtBoxSubmit.Text = "Xác nhận";
            this.txtBoxSubmit.UseVisualStyleBackColor = true;
            this.txtBoxSubmit.Click += new System.EventHandler(this.txtBoxSubmit_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 103);
            this.Controls.Add(this.txtBoxSubmit);
            this.Controls.Add(this.txtBoxSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtBoxSDT;
        private System.Windows.Forms.Button txtBoxSubmit;
    }
}
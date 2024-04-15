namespace ProjectRapChieuPhim
{
    partial class Answer
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxCauHoiBaoMat = new System.Windows.Forms.TextBox();
            this.txtBoxCauTraLoiBaoMat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCauHoiBaoMat = new System.Windows.Forms.Label();
            this.lblYourSDT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxCauHoiBaoMat
            // 
            this.txtBoxCauHoiBaoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCauHoiBaoMat.Location = new System.Drawing.Point(311, 66);
            this.txtBoxCauHoiBaoMat.Name = "txtBoxCauHoiBaoMat";
            this.txtBoxCauHoiBaoMat.Size = new System.Drawing.Size(327, 29);
            this.txtBoxCauHoiBaoMat.TabIndex = 12;
            // 
            // txtBoxCauTraLoiBaoMat
            // 
            this.txtBoxCauTraLoiBaoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCauTraLoiBaoMat.Location = new System.Drawing.Point(311, 110);
            this.txtBoxCauTraLoiBaoMat.Name = "txtBoxCauTraLoiBaoMat";
            this.txtBoxCauTraLoiBaoMat.Size = new System.Drawing.Size(327, 29);
            this.txtBoxCauTraLoiBaoMat.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Câu trả lời";
            // 
            // lblCauHoiBaoMat
            // 
            this.lblCauHoiBaoMat.AutoSize = true;
            this.lblCauHoiBaoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoiBaoMat.Location = new System.Drawing.Point(153, 71);
            this.lblCauHoiBaoMat.Name = "lblCauHoiBaoMat";
            this.lblCauHoiBaoMat.Size = new System.Drawing.Size(152, 24);
            this.lblCauHoiBaoMat.TabIndex = 9;
            this.lblCauHoiBaoMat.Text = "Câu hỏi bảo mật:";
            // 
            // lblYourSDT
            // 
            this.lblYourSDT.AutoSize = true;
            this.lblYourSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourSDT.Location = new System.Drawing.Point(151, 9);
            this.lblYourSDT.Name = "lblYourSDT";
            this.lblYourSDT.Size = new System.Drawing.Size(301, 33);
            this.lblYourSDT.TabIndex = 8;
            this.lblYourSDT.Text = "Tài khoản của bạn là: ";
            // 
            // Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxCauHoiBaoMat);
            this.Controls.Add(this.txtBoxCauTraLoiBaoMat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCauHoiBaoMat);
            this.Controls.Add(this.lblYourSDT);
            this.Name = "Answer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Answer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxCauHoiBaoMat;
        private System.Windows.Forms.TextBox txtBoxCauTraLoiBaoMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCauHoiBaoMat;
        private System.Windows.Forms.Label lblYourSDT;
    }
}
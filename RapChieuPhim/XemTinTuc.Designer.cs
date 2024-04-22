namespace RapChieuPhim
{
    partial class XemTinTuc
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
            this.pnXemTin = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnXemTin
            // 
            this.pnXemTin.AutoScroll = true;
            this.pnXemTin.Location = new System.Drawing.Point(12, 12);
            this.pnXemTin.Name = "pnXemTin";
            this.pnXemTin.Size = new System.Drawing.Size(967, 525);
            this.pnXemTin.TabIndex = 0;
            // 
            // XemTinTuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 549);
            this.Controls.Add(this.pnXemTin);
            this.Name = "XemTinTuc";
            this.Text = "XemTInTuc";
            this.Load += new System.EventHandler(this.XemTInTuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnXemTin;
    }
}
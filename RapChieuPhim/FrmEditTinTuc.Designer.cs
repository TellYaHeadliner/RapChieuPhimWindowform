namespace RapChieuPhim
{
    partial class FrmEditTinTuc
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
            this.btnPathContent = new System.Windows.Forms.Button();
            this.btnPathTitle = new System.Windows.Forms.Button();
            this.txbTieuDe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDuongDanND = new System.Windows.Forms.TextBox();
            this.txbDuongDanTD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.ptrNoiDung = new System.Windows.Forms.PictureBox();
            this.ptrTieuDe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrNoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrTieuDe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPathContent
            // 
            this.btnPathContent.Location = new System.Drawing.Point(172, 331);
            this.btnPathContent.Name = "btnPathContent";
            this.btnPathContent.Size = new System.Drawing.Size(51, 30);
            this.btnPathContent.TabIndex = 25;
            this.btnPathContent.Text = "...";
            this.btnPathContent.UseVisualStyleBackColor = true;
            this.btnPathContent.Click += new System.EventHandler(this.btnPathContent_Click);
            // 
            // btnPathTitle
            // 
            this.btnPathTitle.Location = new System.Drawing.Point(175, 52);
            this.btnPathTitle.Name = "btnPathTitle";
            this.btnPathTitle.Size = new System.Drawing.Size(51, 30);
            this.btnPathTitle.TabIndex = 24;
            this.btnPathTitle.Text = "...";
            this.btnPathTitle.UseVisualStyleBackColor = true;
            this.btnPathTitle.Click += new System.EventHandler(this.btnPathTitle_Click);
            // 
            // txbTieuDe
            // 
            this.txbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTieuDe.Location = new System.Drawing.Point(271, 42);
            this.txbTieuDe.Multiline = true;
            this.txbTieuDe.Name = "txbTieuDe";
            this.txbTieuDe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbTieuDe.Size = new System.Drawing.Size(673, 40);
            this.txbTieuDe.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Title";
            // 
            // txbContent
            // 
            this.txbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContent.Location = new System.Drawing.Point(271, 148);
            this.txbContent.Multiline = true;
            this.txbContent.Name = "txbContent";
            this.txbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbContent.Size = new System.Drawing.Size(692, 314);
            this.txbContent.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Content\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Content Image";
            // 
            // txbDuongDanND
            // 
            this.txbDuongDanND.Enabled = false;
            this.txbDuongDanND.Location = new System.Drawing.Point(10, 331);
            this.txbDuongDanND.Name = "txbDuongDanND";
            this.txbDuongDanND.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDuongDanND.Size = new System.Drawing.Size(156, 20);
            this.txbDuongDanND.TabIndex = 18;
            this.txbDuongDanND.Text = "Path";
            // 
            // txbDuongDanTD
            // 
            this.txbDuongDanTD.Enabled = false;
            this.txbDuongDanTD.Location = new System.Drawing.Point(10, 52);
            this.txbDuongDanTD.Name = "txbDuongDanTD";
            this.txbDuongDanTD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDuongDanTD.Size = new System.Drawing.Size(156, 20);
            this.txbDuongDanTD.TabIndex = 17;
            this.txbDuongDanTD.Text = "Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tittle Image";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(662, 494);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 24);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ptrNoiDung
            // 
            this.ptrNoiDung.Location = new System.Drawing.Point(14, 381);
            this.ptrNoiDung.Name = "ptrNoiDung";
            this.ptrNoiDung.Size = new System.Drawing.Size(138, 138);
            this.ptrNoiDung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrNoiDung.TabIndex = 15;
            this.ptrNoiDung.TabStop = false;
            // 
            // ptrTieuDe
            // 
            this.ptrTieuDe.Location = new System.Drawing.Point(14, 98);
            this.ptrTieuDe.Name = "ptrTieuDe";
            this.ptrTieuDe.Size = new System.Drawing.Size(138, 138);
            this.ptrTieuDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrTieuDe.TabIndex = 14;
            this.ptrTieuDe.TabStop = false;
            // 
            // FrmEditTinTuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(991, 549);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPathContent);
            this.Controls.Add(this.btnPathTitle);
            this.Controls.Add(this.txbTieuDe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDuongDanND);
            this.Controls.Add(this.txbDuongDanTD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptrNoiDung);
            this.Controls.Add(this.ptrTieuDe);
            this.Name = "FrmEditTinTuc";
            this.Text = "FrmEditTinTuc";
            this.Load += new System.EventHandler(this.FrmEditTinTuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrNoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrTieuDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPathContent;
        private System.Windows.Forms.Button btnPathTitle;
        private System.Windows.Forms.TextBox txbTieuDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDuongDanND;
        private System.Windows.Forms.TextBox txbDuongDanTD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptrNoiDung;
        private System.Windows.Forms.PictureBox ptrTieuDe;
        private System.Windows.Forms.Button btnEdit;
    }
}
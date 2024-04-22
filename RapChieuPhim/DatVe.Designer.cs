namespace RapChieuPhim
{
    partial class DatVe
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.tinTuc = new System.Windows.Forms.Panel();
            this.butCheDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.BackgroundImage = global::RapChieuPhim.Properties.Resources.kinhlup;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(935, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 44);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(12, 18);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(917, 31);
            this.search.TabIndex = 12;
            this.search.Tag = "";
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // tinTuc
            // 
            this.tinTuc.AutoScroll = true;
            this.tinTuc.Location = new System.Drawing.Point(12, 101);
            this.tinTuc.Name = "tinTuc";
            this.tinTuc.Size = new System.Drawing.Size(967, 436);
            this.tinTuc.TabIndex = 16;
            // 
            // butCheDo
            // 
            this.butCheDo.Location = new System.Drawing.Point(789, 52);
            this.butCheDo.Name = "butCheDo";
            this.butCheDo.Size = new System.Drawing.Size(140, 43);
            this.butCheDo.TabIndex = 17;
            this.butCheDo.Text = "Xếp theo độ HOT";
            this.butCheDo.UseVisualStyleBackColor = true;
            this.butCheDo.Click += new System.EventHandler(this.butCheDo_Click);
            // 
            // formDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 549);
            this.Controls.Add(this.butCheDo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.tinTuc);
            this.Name = "formDatVe";
            this.Text = "ĐẶT VÉ";
            this.Load += new System.EventHandler(this.formDatVe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCheDo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Panel tinTuc;
    }
}
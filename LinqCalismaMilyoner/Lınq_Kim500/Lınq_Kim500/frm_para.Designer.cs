namespace Lınq_Kim500
{
    partial class frm_para
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_para));
            this.btn_Soru = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Soru
            // 
            this.btn_Soru.AutoEllipsis = true;
            this.btn_Soru.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Soru.BackColor = System.Drawing.Color.Transparent;
            this.btn_Soru.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Soru.BackgroundImage")));
            this.btn_Soru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Soru.FlatAppearance.BorderSize = 0;
            this.btn_Soru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Soru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Soru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Soru.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Soru.Location = new System.Drawing.Point(146, 211);
            this.btn_Soru.Name = "btn_Soru";
            this.btn_Soru.Size = new System.Drawing.Size(140, 20);
            this.btn_Soru.TabIndex = 12;
            this.btn_Soru.Text = "KAPAT";
            this.btn_Soru.UseVisualStyleBackColor = false;
            this.btn_Soru.Click += new System.EventHandler(this.btn_Soru_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 203);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_para
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 238);
            this.Controls.Add(this.btn_Soru);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_para";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_para";
            this.Load += new System.EventHandler(this.frm_para_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Soru;
    }
}
namespace Lınq_Kim500
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Basla = new System.Windows.Forms.Button();
            this.btn_SoruEkle = new System.Windows.Forms.Button();
            this.btn_Cıkıs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "gri.fw.png");
            this.ımageList1.Images.SetKeyName(1, "btn_Basla.fw.png");
            this.ımageList1.Images.SetKeyName(2, "btn_SoruEkle.fw.png");
            this.ımageList1.Images.SetKeyName(3, "btn_cıkıs.fw.png");
            // 
            // btn_Basla
            // 
            this.btn_Basla.ImageKey = "btn_Basla.fw.png";
            this.btn_Basla.ImageList = this.ımageList1;
            this.btn_Basla.Location = new System.Drawing.Point(206, 222);
            this.btn_Basla.Name = "btn_Basla";
            this.btn_Basla.Size = new System.Drawing.Size(224, 30);
            this.btn_Basla.TabIndex = 1;
            this.btn_Basla.UseVisualStyleBackColor = true;
            this.btn_Basla.Click += new System.EventHandler(this.btn_Basla_Click);
            // 
            // btn_SoruEkle
            // 
            this.btn_SoruEkle.ImageKey = "btn_SoruEkle.fw.png";
            this.btn_SoruEkle.ImageList = this.ımageList1;
            this.btn_SoruEkle.Location = new System.Drawing.Point(206, 258);
            this.btn_SoruEkle.Name = "btn_SoruEkle";
            this.btn_SoruEkle.Size = new System.Drawing.Size(224, 34);
            this.btn_SoruEkle.TabIndex = 2;
            this.btn_SoruEkle.UseVisualStyleBackColor = true;
            this.btn_SoruEkle.Click += new System.EventHandler(this.btn_SoruEkle_Click);
            // 
            // btn_Cıkıs
            // 
            this.btn_Cıkıs.ImageKey = "btn_cıkıs.fw.png";
            this.btn_Cıkıs.ImageList = this.ımageList1;
            this.btn_Cıkıs.Location = new System.Drawing.Point(206, 298);
            this.btn_Cıkıs.Name = "btn_Cıkıs";
            this.btn_Cıkıs.Size = new System.Drawing.Size(224, 30);
            this.btn_Cıkıs.TabIndex = 3;
            this.btn_Cıkıs.UseVisualStyleBackColor = true;
            this.btn_Cıkıs.Click += new System.EventHandler(this.btn_Cıkıs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 385);
            this.Controls.Add(this.btn_Cıkıs);
            this.Controls.Add(this.btn_SoruEkle);
            this.Controls.Add(this.btn_Basla);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_Basla;
        private System.Windows.Forms.Button btn_SoruEkle;
        private System.Windows.Forms.Button btn_Cıkıs;
    }
}


namespace OgretmenKayit
{
    partial class frmOgrtmnKayit
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
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.txtOgrtmnAd = new System.Windows.Forms.TextBox();
            this.txtOgrtmnSoyad = new System.Windows.Forms.TextBox();
            this.txtOgretmenTc = new System.Windows.Forms.TextBox();
            this.lblOgretmenAd = new System.Windows.Forms.Label();
            this.lblOgrtmnSoyad = new System.Windows.Forms.Label();
            this.lblOgrtmnTc = new System.Windows.Forms.Label();
            this.btnOgrtmnKaydet = new System.Windows.Forms.Button();
            this.grpOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.lblOgrtmnTc);
            this.grpOgretmen.Controls.Add(this.lblOgrtmnSoyad);
            this.grpOgretmen.Controls.Add(this.lblOgretmenAd);
            this.grpOgretmen.Controls.Add(this.txtOgretmenTc);
            this.grpOgretmen.Controls.Add(this.txtOgrtmnSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgrtmnAd);
            this.grpOgretmen.Location = new System.Drawing.Point(12, 12);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Size = new System.Drawing.Size(322, 224);
            this.grpOgretmen.TabIndex = 0;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Öğretmen Bilgileri";
            // 
            // txtOgrtmnAd
            // 
            this.txtOgrtmnAd.Location = new System.Drawing.Point(117, 69);
            this.txtOgrtmnAd.Name = "txtOgrtmnAd";
            this.txtOgrtmnAd.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtmnAd.TabIndex = 0;
            // 
            // txtOgrtmnSoyad
            // 
            this.txtOgrtmnSoyad.Location = new System.Drawing.Point(117, 99);
            this.txtOgrtmnSoyad.Name = "txtOgrtmnSoyad";
            this.txtOgrtmnSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtmnSoyad.TabIndex = 1;
            // 
            // txtOgretmenTc
            // 
            this.txtOgretmenTc.Location = new System.Drawing.Point(117, 132);
            this.txtOgretmenTc.Name = "txtOgretmenTc";
            this.txtOgretmenTc.Size = new System.Drawing.Size(100, 20);
            this.txtOgretmenTc.TabIndex = 2;
            // 
            // lblOgretmenAd
            // 
            this.lblOgretmenAd.AutoSize = true;
            this.lblOgretmenAd.Location = new System.Drawing.Point(91, 76);
            this.lblOgretmenAd.Name = "lblOgretmenAd";
            this.lblOgretmenAd.Size = new System.Drawing.Size(20, 13);
            this.lblOgretmenAd.TabIndex = 3;
            this.lblOgretmenAd.Text = "Ad";
            // 
            // lblOgrtmnSoyad
            // 
            this.lblOgrtmnSoyad.AutoSize = true;
            this.lblOgrtmnSoyad.Location = new System.Drawing.Point(74, 106);
            this.lblOgrtmnSoyad.Name = "lblOgrtmnSoyad";
            this.lblOgrtmnSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblOgrtmnSoyad.TabIndex = 4;
            this.lblOgrtmnSoyad.Text = "Soyad";
            // 
            // lblOgrtmnTc
            // 
            this.lblOgrtmnTc.AutoSize = true;
            this.lblOgrtmnTc.Location = new System.Drawing.Point(7, 139);
            this.lblOgrtmnTc.Name = "lblOgrtmnTc";
            this.lblOgrtmnTc.Size = new System.Drawing.Size(104, 13);
            this.lblOgrtmnTc.TabIndex = 5;
            this.lblOgrtmnTc.Text = "T.C. Kimlik Numarası";
            // 
            // btnOgrtmnKaydet
            // 
            this.btnOgrtmnKaydet.Location = new System.Drawing.Point(106, 252);
            this.btnOgrtmnKaydet.Name = "btnOgrtmnKaydet";
            this.btnOgrtmnKaydet.Size = new System.Drawing.Size(140, 25);
            this.btnOgrtmnKaydet.TabIndex = 1;
            this.btnOgrtmnKaydet.Text = "Kaydet";
            this.btnOgrtmnKaydet.UseVisualStyleBackColor = true;
            this.btnOgrtmnKaydet.Click += new System.EventHandler(this.btnOgrtmnKaydet_Click);
            // 
            // frmOgrtmnKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 289);
            this.Controls.Add(this.btnOgrtmnKaydet);
            this.Controls.Add(this.grpOgretmen);
            this.Name = "frmOgrtmnKayit";
            this.Text = "Öğretmen Kayıt İşlemleri";
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.Windows.Forms.Label lblOgrtmnTc;
        private System.Windows.Forms.Label lblOgrtmnSoyad;
        private System.Windows.Forms.Label lblOgretmenAd;
        private System.Windows.Forms.TextBox txtOgretmenTc;
        private System.Windows.Forms.TextBox txtOgrtmnSoyad;
        private System.Windows.Forms.TextBox txtOgrtmnAd;
        private System.Windows.Forms.Button btnOgrtmnKaydet;
    }
}


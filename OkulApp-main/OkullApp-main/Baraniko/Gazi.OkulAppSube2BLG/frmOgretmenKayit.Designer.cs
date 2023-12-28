namespace Gazi.OkulAppSube2BLG
{
    partial class frmOgretmenKayit
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblOgretmenAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOgretmenTc = new System.Windows.Forms.TextBox();
            this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(215, 359);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(157, 38);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblOgretmenAd
            // 
            this.lblOgretmenAd.AutoSize = true;
            this.lblOgretmenAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgretmenAd.Location = new System.Drawing.Point(40, 52);
            this.lblOgretmenAd.Name = "lblOgretmenAd";
            this.lblOgretmenAd.Size = new System.Drawing.Size(30, 16);
            this.lblOgretmenAd.TabIndex = 1;
            this.lblOgretmenAd.Text = "Adı";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(40, 120);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(52, 16);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(40, 187);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(53, 16);
            this.lblTc.TabIndex = 3;
            this.lblTc.Text = "TC NO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOgretmenTc);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.txtOgretmenSoyad);
            this.groupBox1.Controls.Add(this.txtOgretmenAd);
            this.groupBox1.Controls.Add(this.lblOgretmenAd);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(103, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 257);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Bilgileri";
            // 
            // txtOgretmenTc
            // 
            this.txtOgretmenTc.Location = new System.Drawing.Point(188, 187);
            this.txtOgretmenTc.Name = "txtOgretmenTc";
            this.txtOgretmenTc.Size = new System.Drawing.Size(100, 22);
            this.txtOgretmenTc.TabIndex = 2;
            // 
            // txtOgretmenSoyad
            // 
            this.txtOgretmenSoyad.Location = new System.Drawing.Point(188, 114);
            this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            this.txtOgretmenSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtOgretmenSoyad.TabIndex = 1;
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.Location = new System.Drawing.Point(188, 52);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(100, 22);
            this.txtOgretmenAd.TabIndex = 0;
            // 
            // frmOgretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmOgretmenKayit";
            this.Text = "Öğretmen Kayıt İşlemi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblOgretmenAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOgretmenTc;
        private System.Windows.Forms.TextBox txtOgretmenSoyad;
        private System.Windows.Forms.TextBox txtOgretmenAd;
    }
}
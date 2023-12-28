namespace Gazi.OkulAppSube2BLG
{
    partial class frmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOgrenciKayit = new System.Windows.Forms.Button();
            this.btnOgretmenKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİNİZ YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ.";
            // 
            // btnOgrenciKayit
            // 
            this.btnOgrenciKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOgrenciKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciKayit.Location = new System.Drawing.Point(88, 226);
            this.btnOgrenciKayit.Name = "btnOgrenciKayit";
            this.btnOgrenciKayit.Size = new System.Drawing.Size(228, 77);
            this.btnOgrenciKayit.TabIndex = 1;
            this.btnOgrenciKayit.Text = "ÖĞRENCİ KAYIT";
            this.btnOgrenciKayit.UseVisualStyleBackColor = false;
            this.btnOgrenciKayit.Click += new System.EventHandler(this.btnOgrenciKayit_Click);
            // 
            // btnOgretmenKayit
            // 
            this.btnOgretmenKayit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOgretmenKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenKayit.Location = new System.Drawing.Point(459, 226);
            this.btnOgretmenKayit.Name = "btnOgretmenKayit";
            this.btnOgretmenKayit.Size = new System.Drawing.Size(228, 77);
            this.btnOgretmenKayit.TabIndex = 2;
            this.btnOgretmenKayit.Text = "ÖĞRETMEN KAYIT";
            this.btnOgretmenKayit.UseVisualStyleBackColor = false;
            this.btnOgretmenKayit.Click += new System.EventHandler(this.btnOgretmenKayit_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.btnOgretmenKayit);
            this.Controls.Add(this.btnOgrenciKayit);
            this.Controls.Add(this.label1);
            this.Name = "frmGiris";
            this.Text = "Öğrenci/Öğretmen Kayıt İşlemi Seçimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrenciKayit;
        private System.Windows.Forms.Button btnOgretmenKayit;
    }
}
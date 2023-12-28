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
            this.btnOgrenciKayit = new System.Windows.Forms.Button();
            this.btnOgretmenKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciKayit
            // 
            this.btnOgrenciKayit.BackColor = System.Drawing.Color.White;
            this.btnOgrenciKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciKayit.Location = new System.Drawing.Point(103, 61);
            this.btnOgrenciKayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOgrenciKayit.Name = "btnOgrenciKayit";
            this.btnOgrenciKayit.Size = new System.Drawing.Size(133, 83);
            this.btnOgrenciKayit.TabIndex = 1;
            this.btnOgrenciKayit.Text = "ÖĞRENCİ KAYIT";
            this.btnOgrenciKayit.UseVisualStyleBackColor = false;
            this.btnOgrenciKayit.Click += new System.EventHandler(this.btnOgrenciKayit_Click);
            // 
            // btnOgretmenKayit
            // 
            this.btnOgretmenKayit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOgretmenKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenKayit.Location = new System.Drawing.Point(103, 170);
            this.btnOgretmenKayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOgretmenKayit.Name = "btnOgretmenKayit";
            this.btnOgretmenKayit.Size = new System.Drawing.Size(133, 71);
            this.btnOgretmenKayit.TabIndex = 2;
            this.btnOgretmenKayit.Text = "ÖĞRETMEN KAYIT";
            this.btnOgretmenKayit.UseVisualStyleBackColor = false;
            this.btnOgretmenKayit.Click += new System.EventHandler(this.btnOgretmenKayit_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 283);
            this.Controls.Add(this.btnOgretmenKayit);
            this.Controls.Add(this.btnOgrenciKayit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGiris";
            this.Text = "Öğrenci/Öğretmen Kayıt İşlemi Seçimi";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOgrenciKayit;
        private System.Windows.Forms.Button btnOgretmenKayit;
    }
}
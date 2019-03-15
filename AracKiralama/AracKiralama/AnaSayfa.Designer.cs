namespace NYPProje
{
    partial class AnaSayfa
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
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Personel = new System.Windows.Forms.Button();
            this.btn_ArabaKiralama = new System.Windows.Forms.Button();
            this.bt_ArabaEkle = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(12, 50);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(127, 35);
            this.btn_Admin.TabIndex = 0;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Personel
            // 
            this.btn_Personel.Location = new System.Drawing.Point(438, 50);
            this.btn_Personel.Name = "btn_Personel";
            this.btn_Personel.Size = new System.Drawing.Size(142, 35);
            this.btn_Personel.TabIndex = 1;
            this.btn_Personel.Text = "Personel Ekle";
            this.btn_Personel.UseVisualStyleBackColor = true;
            this.btn_Personel.Click += new System.EventHandler(this.btn_Personel_Click);
            // 
            // btn_ArabaKiralama
            // 
            this.btn_ArabaKiralama.Location = new System.Drawing.Point(145, 50);
            this.btn_ArabaKiralama.Name = "btn_ArabaKiralama";
            this.btn_ArabaKiralama.Size = new System.Drawing.Size(134, 35);
            this.btn_ArabaKiralama.TabIndex = 1;
            this.btn_ArabaKiralama.Text = "ArabaKiralama";
            this.btn_ArabaKiralama.UseVisualStyleBackColor = true;
            this.btn_ArabaKiralama.Click += new System.EventHandler(this.btn_ArabaKiralama_Click);
            // 
            // bt_ArabaEkle
            // 
            this.bt_ArabaEkle.Location = new System.Drawing.Point(285, 50);
            this.bt_ArabaEkle.Name = "bt_ArabaEkle";
            this.bt_ArabaEkle.Size = new System.Drawing.Size(147, 35);
            this.bt_ArabaEkle.TabIndex = 2;
            this.bt_ArabaEkle.Text = "Araba Ekle";
            this.bt_ArabaEkle.UseVisualStyleBackColor = true;
            this.bt_ArabaEkle.Click += new System.EventHandler(this.bt_ArabaEkle_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(586, 50);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(115, 35);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 149);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.bt_ArabaEkle);
            this.Controls.Add(this.btn_ArabaKiralama);
            this.Controls.Add(this.btn_Personel);
            this.Controls.Add(this.btn_Admin);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Personel;
        private System.Windows.Forms.Button btn_ArabaKiralama;
        private System.Windows.Forms.Button bt_ArabaEkle;
        private System.Windows.Forms.Button btn_cikis;
    }
}
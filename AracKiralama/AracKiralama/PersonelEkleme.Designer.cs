namespace NYPProje
{
    partial class PersonelEkleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_Kayit = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_cinsiyet = new System.Windows.Forms.ComboBox();
            this.txt_Maas = new System.Windows.Forms.TextBox();
            this.data_Kayit = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PersonelAdi = new System.Windows.Forms.TextBox();
            this.kullanici_Adi = new System.Windows.Forms.Label();
            this.data_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PersonelSoyadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 293);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(894, 416);
            this.dataGridView1.TabIndex = 121;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(882, 241);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(73, 31);
            this.btn_sil.TabIndex = 120;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(779, 241);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(95, 31);
            this.btn_guncelle.TabIndex = 119;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(600, 241);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(76, 31);
            this.btn_cikis.TabIndex = 118;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.Location = new System.Drawing.Point(684, 241);
            this.btn_Kayit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(87, 31);
            this.btn_Kayit.TabIndex = 117;
            this.btn_Kayit.Text = "Kaydet";
            this.btn_Kayit.UseVisualStyleBackColor = true;
            this.btn_Kayit.Click += new System.EventHandler(this.btn_Kayit_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(507, 241);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(91, 31);
            this.btn_geri.TabIndex = 116;
            this.btn_geri.Text = "<-- Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(563, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 114;
            this.label10.Text = "Maaş:";
            // 
            // combo_cinsiyet
            // 
            this.combo_cinsiyet.FormattingEnabled = true;
            this.combo_cinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.combo_cinsiyet.Location = new System.Drawing.Point(625, 80);
            this.combo_cinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.combo_cinsiyet.Name = "combo_cinsiyet";
            this.combo_cinsiyet.Size = new System.Drawing.Size(216, 27);
            this.combo_cinsiyet.TabIndex = 122;
            // 
            // txt_Maas
            // 
            this.txt_Maas.Location = new System.Drawing.Point(625, 46);
            this.txt_Maas.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Maas.Name = "txt_Maas";
            this.txt_Maas.Size = new System.Drawing.Size(216, 26);
            this.txt_Maas.TabIndex = 115;
            // 
            // data_Kayit
            // 
            this.data_Kayit.Location = new System.Drawing.Point(625, 149);
            this.data_Kayit.Margin = new System.Windows.Forms.Padding(4);
            this.data_Kayit.Name = "data_Kayit";
            this.data_Kayit.Size = new System.Drawing.Size(272, 26);
            this.data_Kayit.TabIndex = 113;
            this.data_Kayit.Value = new System.DateTime(2017, 12, 10, 11, 20, 10, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 112;
            this.label9.Text = "Kayıt Tarihi:";
            // 
            // txt_PersonelAdi
            // 
            this.txt_PersonelAdi.Location = new System.Drawing.Point(174, 46);
            this.txt_PersonelAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PersonelAdi.Name = "txt_PersonelAdi";
            this.txt_PersonelAdi.Size = new System.Drawing.Size(292, 26);
            this.txt_PersonelAdi.TabIndex = 108;
            // 
            // kullanici_Adi
            // 
            this.kullanici_Adi.AutoSize = true;
            this.kullanici_Adi.Location = new System.Drawing.Point(121, 49);
            this.kullanici_Adi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kullanici_Adi.Name = "kullanici_Adi";
            this.kullanici_Adi.Size = new System.Drawing.Size(45, 19);
            this.kullanici_Adi.TabIndex = 107;
            this.kullanici_Adi.Text = "Adı:";
            // 
            // data_DogumTarihi
            // 
            this.data_DogumTarihi.Location = new System.Drawing.Point(625, 115);
            this.data_DogumTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.data_DogumTarihi.Name = "data_DogumTarihi";
            this.data_DogumTarihi.Size = new System.Drawing.Size(272, 26);
            this.data_DogumTarihi.TabIndex = 104;
            this.data_DogumTarihi.Value = new System.DateTime(2017, 12, 10, 11, 20, 10, 0);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(625, 178);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(272, 26);
            this.txt_email.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(359, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 34);
            this.label8.TabIndex = 111;
            this.label8.Text = "****Personel Ekle****";
            // 
            // txt_PersonelSoyadi
            // 
            this.txt_PersonelSoyadi.Location = new System.Drawing.Point(174, 88);
            this.txt_PersonelSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PersonelSoyadi.Name = "txt_PersonelSoyadi";
            this.txt_PersonelSoyadi.Size = new System.Drawing.Size(292, 26);
            this.txt_PersonelSoyadi.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 109;
            this.label7.Text = "Soyadı:";
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(174, 178);
            this.txt_Adres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Adres.Multiline = true;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(292, 94);
            this.txt_Adres.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 98;
            this.label5.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 97;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 96;
            this.label3.Text = "Cinsiyet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 95;
            this.label2.Text = "Adres:";
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(174, 132);
            this.txt_TC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(292, 26);
            this.txt_TC.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 93;
            this.label1.Text = "TC:";
            // 
            // PersonelEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 722);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_Kayit);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combo_cinsiyet);
            this.Controls.Add(this.txt_Maas);
            this.Controls.Add(this.data_Kayit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_PersonelAdi);
            this.Controls.Add(this.kullanici_Adi);
            this.Controls.Add(this.data_DogumTarihi);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_PersonelSoyadi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelEkleme";
            this.Load += new System.EventHandler(this.PersonelEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_Kayit;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo_cinsiyet;
        private System.Windows.Forms.TextBox txt_Maas;
        private System.Windows.Forms.DateTimePicker data_Kayit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_PersonelAdi;
        private System.Windows.Forms.Label kullanici_Adi;
        private System.Windows.Forms.DateTimePicker data_DogumTarihi;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PersonelSoyadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label label1;
    }
}
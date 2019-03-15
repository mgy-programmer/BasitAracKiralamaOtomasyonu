namespace NYPProje
{
    partial class ArabaKiralama
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.date_kayit = new System.Windows.Forms.DateTimePicker();
            this.combo_Personel = new System.Windows.Forms.ComboBox();
            this.combo_ArabaModel = new System.Windows.Forms.ComboBox();
            this.combo_arabaMarka = new System.Windows.Forms.ComboBox();
            this.date_ehliyet = new System.Windows.Forms.DateTimePicker();
            this.date_musteriDT = new System.Windows.Forms.DateTimePicker();
            this.txt_gunluk = new System.Windows.Forms.TextBox();
            this.txt_gun = new System.Windows.Forms.TextBox();
            this.txt_musteriSoyadi = new System.Windows.Forms.TextBox();
            this.txt_musteriAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_musteriTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.nYPProjemDataSet1 = new NYPProje.NYPProjemDataSet1();
            this.arabaMarkasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arabaMarkasTableAdapter = new NYPProje.NYPProjemDataSet1TableAdapters.ArabaMarkasTableAdapter();
            this.nYPProjemDataSet2 = new NYPProje.NYPProjemDataSet2();
            this.personelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelsTableAdapter = new NYPProje.NYPProjemDataSet2TableAdapters.PersonelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYPProjemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaMarkasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYPProjemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(939, 335);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(412, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 24);
            this.label12.TabIndex = 55;
            this.label12.Text = "ARABA KİRALA";
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(719, 247);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(104, 32);
            this.btn_cikis.TabIndex = 54;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(578, 247);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(104, 32);
            this.btn_geri.TabIndex = 53;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(416, 247);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(104, 32);
            this.btn_sil.TabIndex = 52;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(246, 247);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(104, 32);
            this.btn_guncelle.TabIndex = 51;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // date_kayit
            // 
            this.date_kayit.Location = new System.Drawing.Point(640, 118);
            this.date_kayit.Name = "date_kayit";
            this.date_kayit.Size = new System.Drawing.Size(265, 26);
            this.date_kayit.TabIndex = 50;
            // 
            // combo_Personel
            // 
            this.combo_Personel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personelsBindingSource, "PersonelAdi", true));
            this.combo_Personel.DataSource = this.personelsBindingSource;
            this.combo_Personel.DisplayMember = "PersonelAdi";
            this.combo_Personel.FormattingEnabled = true;
            this.combo_Personel.Location = new System.Drawing.Point(234, 205);
            this.combo_Personel.Name = "combo_Personel";
            this.combo_Personel.Size = new System.Drawing.Size(263, 27);
            this.combo_Personel.TabIndex = 49;
            this.combo_Personel.ValueMember = "PersonelAdi";
            // 
            // combo_ArabaModel
            // 
            this.combo_ArabaModel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.arabaMarkasBindingSource, "Model", true));
            this.combo_ArabaModel.DataSource = this.arabaMarkasBindingSource;
            this.combo_ArabaModel.DisplayMember = "Model";
            this.combo_ArabaModel.FormattingEnabled = true;
            this.combo_ArabaModel.Location = new System.Drawing.Point(640, 85);
            this.combo_ArabaModel.Name = "combo_ArabaModel";
            this.combo_ArabaModel.Size = new System.Drawing.Size(265, 27);
            this.combo_ArabaModel.TabIndex = 48;
            this.combo_ArabaModel.ValueMember = "id";
            // 
            // combo_arabaMarka
            // 
            this.combo_arabaMarka.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.arabaMarkasBindingSource, "Marka", true));
            this.combo_arabaMarka.DataSource = this.arabaMarkasBindingSource;
            this.combo_arabaMarka.DisplayMember = "Marka";
            this.combo_arabaMarka.FormattingEnabled = true;
            this.combo_arabaMarka.Location = new System.Drawing.Point(640, 53);
            this.combo_arabaMarka.Name = "combo_arabaMarka";
            this.combo_arabaMarka.Size = new System.Drawing.Size(265, 27);
            this.combo_arabaMarka.TabIndex = 47;
            this.combo_arabaMarka.ValueMember = "id";
            // 
            // date_ehliyet
            // 
            this.date_ehliyet.Location = new System.Drawing.Point(234, 174);
            this.date_ehliyet.Name = "date_ehliyet";
            this.date_ehliyet.Size = new System.Drawing.Size(263, 26);
            this.date_ehliyet.TabIndex = 46;
            // 
            // date_musteriDT
            // 
            this.date_musteriDT.Location = new System.Drawing.Point(234, 143);
            this.date_musteriDT.Name = "date_musteriDT";
            this.date_musteriDT.Size = new System.Drawing.Size(263, 26);
            this.date_musteriDT.TabIndex = 45;
            // 
            // txt_gunluk
            // 
            this.txt_gunluk.Location = new System.Drawing.Point(640, 179);
            this.txt_gunluk.Name = "txt_gunluk";
            this.txt_gunluk.Size = new System.Drawing.Size(232, 26);
            this.txt_gunluk.TabIndex = 44;
            // 
            // txt_gun
            // 
            this.txt_gun.Location = new System.Drawing.Point(640, 150);
            this.txt_gun.Name = "txt_gun";
            this.txt_gun.Size = new System.Drawing.Size(169, 26);
            this.txt_gun.TabIndex = 43;
            // 
            // txt_musteriSoyadi
            // 
            this.txt_musteriSoyadi.Location = new System.Drawing.Point(234, 112);
            this.txt_musteriSoyadi.Name = "txt_musteriSoyadi";
            this.txt_musteriSoyadi.Size = new System.Drawing.Size(263, 26);
            this.txt_musteriSoyadi.TabIndex = 42;
            // 
            // txt_musteriAdi
            // 
            this.txt_musteriAdi.Location = new System.Drawing.Point(234, 81);
            this.txt_musteriAdi.Name = "txt_musteriAdi";
            this.txt_musteriAdi.Size = new System.Drawing.Size(263, 26);
            this.txt_musteriAdi.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(508, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "Günlük Ücret:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "Gün Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Kayıt Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Araba Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "Araba Marka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Personel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ehliyet Alındığı Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Müşteri Dogum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Müşteri Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Müşteri Adı:";
            // 
            // txt_musteriTC
            // 
            this.txt_musteriTC.Location = new System.Drawing.Point(234, 50);
            this.txt_musteriTC.Name = "txt_musteriTC";
            this.txt_musteriTC.Size = new System.Drawing.Size(263, 26);
            this.txt_musteriTC.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Müşteri TC:";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(93, 247);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(104, 32);
            this.btn_Ekle.TabIndex = 28;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // nYPProjemDataSet1
            // 
            this.nYPProjemDataSet1.DataSetName = "NYPProjemDataSet1";
            this.nYPProjemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arabaMarkasBindingSource
            // 
            this.arabaMarkasBindingSource.DataMember = "ArabaMarkas";
            this.arabaMarkasBindingSource.DataSource = this.nYPProjemDataSet1;
            // 
            // arabaMarkasTableAdapter
            // 
            this.arabaMarkasTableAdapter.ClearBeforeFill = true;
            // 
            // nYPProjemDataSet2
            // 
            this.nYPProjemDataSet2.DataSetName = "NYPProjemDataSet2";
            this.nYPProjemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelsBindingSource
            // 
            this.personelsBindingSource.DataMember = "Personels";
            this.personelsBindingSource.DataSource = this.nYPProjemDataSet2;
            // 
            // personelsTableAdapter
            // 
            this.personelsTableAdapter.ClearBeforeFill = true;
            // 
            // ArabaKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 631);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.date_kayit);
            this.Controls.Add(this.combo_Personel);
            this.Controls.Add(this.combo_ArabaModel);
            this.Controls.Add(this.combo_arabaMarka);
            this.Controls.Add(this.date_ehliyet);
            this.Controls.Add(this.date_musteriDT);
            this.Controls.Add(this.txt_gunluk);
            this.Controls.Add(this.txt_gun);
            this.Controls.Add(this.txt_musteriSoyadi);
            this.Controls.Add(this.txt_musteriAdi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_musteriTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ekle);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArabaKiralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArabaKiralama";
            this.Load += new System.EventHandler(this.ArabaKiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYPProjemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaMarkasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYPProjemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.DateTimePicker date_kayit;
        private System.Windows.Forms.ComboBox combo_Personel;
        private System.Windows.Forms.ComboBox combo_ArabaModel;
        private System.Windows.Forms.ComboBox combo_arabaMarka;
        private System.Windows.Forms.DateTimePicker date_ehliyet;
        private System.Windows.Forms.DateTimePicker date_musteriDT;
        private System.Windows.Forms.TextBox txt_gunluk;
        private System.Windows.Forms.TextBox txt_gun;
        private System.Windows.Forms.TextBox txt_musteriSoyadi;
        private System.Windows.Forms.TextBox txt_musteriAdi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_musteriTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ekle;
        private NYPProjemDataSet1 nYPProjemDataSet1;
        private System.Windows.Forms.BindingSource arabaMarkasBindingSource;
        private NYPProjemDataSet1TableAdapters.ArabaMarkasTableAdapter arabaMarkasTableAdapter;
        private NYPProjemDataSet2 nYPProjemDataSet2;
        private System.Windows.Forms.BindingSource personelsBindingSource;
        private NYPProjemDataSet2TableAdapters.PersonelsTableAdapter personelsTableAdapter;
    }
}
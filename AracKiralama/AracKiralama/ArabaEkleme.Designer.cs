namespace NYPProje
{
    partial class ArabaEkleme
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_arabaModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.data_marka = new System.Windows.Forms.DataGridView();
            this.btn_MarkaDuzelt = new System.Windows.Forms.Button();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_markaKaydet = new System.Windows.Forms.Button();
            this.txt_kapi = new System.Windows.Forms.TextBox();
            this.txt_renk = new System.Windows.Forms.TextBox();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.txt_yili = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_duzelt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_model = new System.Windows.Forms.ComboBox();
            this.combo_marka = new System.Windows.Forms.ComboBox();
            this.btn_arabaSil = new System.Windows.Forms.Button();
            this.data_araba = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nYPProjemDataSet = new NYPProje.NYPProjemDataSet();
            this.arabaMarkasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arabaMarkasTableAdapter = new NYPProje.NYPProjemDataSetTableAdapters.ArabaMarkasTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_marka)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_araba)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYPProjemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaMarkasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_arabaModel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.data_marka);
            this.groupBox2.Controls.Add(this.btn_MarkaDuzelt);
            this.groupBox2.Controls.Add(this.txt_marka);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_markaKaydet);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(432, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 277);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marka Ekle";
            // 
            // txt_arabaModel
            // 
            this.txt_arabaModel.Location = new System.Drawing.Point(156, 60);
            this.txt_arabaModel.Name = "txt_arabaModel";
            this.txt_arabaModel.Size = new System.Drawing.Size(216, 25);
            this.txt_arabaModel.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Araba Modeli:";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(267, 95);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 18;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // data_marka
            // 
            this.data_marka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_marka.Location = new System.Drawing.Point(15, 124);
            this.data_marka.Name = "data_marka";
            this.data_marka.Size = new System.Drawing.Size(414, 143);
            this.data_marka.TabIndex = 17;
            this.data_marka.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_marka_CellClick);
            // 
            // btn_MarkaDuzelt
            // 
            this.btn_MarkaDuzelt.Location = new System.Drawing.Point(79, 95);
            this.btn_MarkaDuzelt.Name = "btn_MarkaDuzelt";
            this.btn_MarkaDuzelt.Size = new System.Drawing.Size(101, 23);
            this.btn_MarkaDuzelt.TabIndex = 16;
            this.btn_MarkaDuzelt.Text = "Düzelt";
            this.btn_MarkaDuzelt.UseVisualStyleBackColor = true;
            this.btn_MarkaDuzelt.Click += new System.EventHandler(this.btn_MarkaDuzelt_Click);
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(152, 26);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(220, 25);
            this.txt_marka.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Araba Markası:";
            // 
            // btn_markaKaydet
            // 
            this.btn_markaKaydet.Location = new System.Drawing.Point(186, 95);
            this.btn_markaKaydet.Name = "btn_markaKaydet";
            this.btn_markaKaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_markaKaydet.TabIndex = 9;
            this.btn_markaKaydet.Text = "Kaydet";
            this.btn_markaKaydet.UseVisualStyleBackColor = true;
            this.btn_markaKaydet.Click += new System.EventHandler(this.btn_markaKaydet_Click);
            // 
            // txt_kapi
            // 
            this.txt_kapi.Location = new System.Drawing.Point(164, 194);
            this.txt_kapi.Name = "txt_kapi";
            this.txt_kapi.Size = new System.Drawing.Size(208, 25);
            this.txt_kapi.TabIndex = 15;
            // 
            // txt_renk
            // 
            this.txt_renk.Location = new System.Drawing.Point(164, 165);
            this.txt_renk.Name = "txt_renk";
            this.txt_renk.Size = new System.Drawing.Size(208, 25);
            this.txt_renk.TabIndex = 14;
            // 
            // txt_tur
            // 
            this.txt_tur.Location = new System.Drawing.Point(164, 133);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(208, 25);
            this.txt_tur.TabIndex = 13;
            // 
            // txt_yili
            // 
            this.txt_yili.Location = new System.Drawing.Point(164, 104);
            this.txt_yili.Name = "txt_yili";
            this.txt_yili.Size = new System.Drawing.Size(208, 25);
            this.txt_yili.TabIndex = 12;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(13, 244);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(82, 23);
            this.btn_geri.TabIndex = 8;
            this.btn_geri.Text = "<== Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(188, 245);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(81, 23);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Araba Kapı Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Araba Rengi:";
            // 
            // btn_duzelt
            // 
            this.btn_duzelt.Location = new System.Drawing.Point(101, 244);
            this.btn_duzelt.Name = "btn_duzelt";
            this.btn_duzelt.Size = new System.Drawing.Size(81, 23);
            this.btn_duzelt.TabIndex = 0;
            this.btn_duzelt.Text = "Düzelt";
            this.btn_duzelt.UseVisualStyleBackColor = true;
            this.btn_duzelt.Click += new System.EventHandler(this.btn_duzelt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Araba Tür:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Araba Yılı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Araba Modeli:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Araba Markası:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_model);
            this.groupBox1.Controls.Add(this.combo_marka);
            this.groupBox1.Controls.Add(this.btn_arabaSil);
            this.groupBox1.Controls.Add(this.txt_kapi);
            this.groupBox1.Controls.Add(this.txt_renk);
            this.groupBox1.Controls.Add(this.txt_tur);
            this.groupBox1.Controls.Add(this.txt_yili);
            this.groupBox1.Controls.Add(this.btn_geri);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_duzelt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 277);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araba Ekle";
            // 
            // combo_model
            // 
            this.combo_model.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.arabaMarkasBindingSource, "Model", true));
            this.combo_model.DataSource = this.arabaMarkasBindingSource;
            this.combo_model.DisplayMember = "Model";
            this.combo_model.FormattingEnabled = true;
            this.combo_model.Location = new System.Drawing.Point(164, 71);
            this.combo_model.Name = "combo_model";
            this.combo_model.Size = new System.Drawing.Size(208, 26);
            this.combo_model.TabIndex = 20;
            this.combo_model.ValueMember = "id";
            // 
            // combo_marka
            // 
            this.combo_marka.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.arabaMarkasBindingSource, "Marka", true));
            this.combo_marka.DataSource = this.arabaMarkasBindingSource;
            this.combo_marka.DisplayMember = "Marka";
            this.combo_marka.FormattingEnabled = true;
            this.combo_marka.Location = new System.Drawing.Point(164, 32);
            this.combo_marka.Name = "combo_marka";
            this.combo_marka.Size = new System.Drawing.Size(208, 26);
            this.combo_marka.TabIndex = 19;
            this.combo_marka.ValueMember = "id";
            // 
            // btn_arabaSil
            // 
            this.btn_arabaSil.Location = new System.Drawing.Point(275, 245);
            this.btn_arabaSil.Name = "btn_arabaSil";
            this.btn_arabaSil.Size = new System.Drawing.Size(80, 23);
            this.btn_arabaSil.TabIndex = 17;
            this.btn_arabaSil.Text = "Sil";
            this.btn_arabaSil.UseVisualStyleBackColor = true;
            this.btn_arabaSil.Click += new System.EventHandler(this.btn_arabaSil_Click);
            // 
            // data_araba
            // 
            this.data_araba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_araba.Location = new System.Drawing.Point(17, 24);
            this.data_araba.Name = "data_araba";
            this.data_araba.Size = new System.Drawing.Size(846, 304);
            this.data_araba.TabIndex = 18;
            this.data_araba.Click += new System.EventHandler(this.data_araba_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.data_araba);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(15, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(869, 334);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // nYPProjemDataSet
            // 
            this.nYPProjemDataSet.DataSetName = "NYPProjemDataSet";
            this.nYPProjemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arabaMarkasBindingSource
            // 
            this.arabaMarkasBindingSource.DataMember = "ArabaMarkas";
            this.arabaMarkasBindingSource.DataSource = this.nYPProjemDataSet;
            // 
            // arabaMarkasTableAdapter
            // 
            this.arabaMarkasTableAdapter.ClearBeforeFill = true;
            // 
            // ArabaEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArabaEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArabaEkleme";
            this.Load += new System.EventHandler(this.ArabaEkleme_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_marka)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_araba)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nYPProjemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaMarkasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView data_marka;
        private System.Windows.Forms.Button btn_MarkaDuzelt;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_markaKaydet;
        private System.Windows.Forms.TextBox txt_kapi;
        private System.Windows.Forms.TextBox txt_renk;
        private System.Windows.Forms.TextBox txt_tur;
        private System.Windows.Forms.TextBox txt_yili;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_duzelt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data_araba;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_arabaSil;
        private System.Windows.Forms.TextBox txt_arabaModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_model;
        private System.Windows.Forms.ComboBox combo_marka;
        private NYPProjemDataSet nYPProjemDataSet;
        private System.Windows.Forms.BindingSource arabaMarkasBindingSource;
        private NYPProjemDataSetTableAdapters.ArabaMarkasTableAdapter arabaMarkasTableAdapter;
    }
}
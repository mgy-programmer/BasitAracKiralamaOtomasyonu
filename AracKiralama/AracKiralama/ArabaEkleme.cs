using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NYPProje.Model.Data;
using NYPProje.Model.Context;
using System.Data.SqlClient;

namespace NYPProje
{
    public partial class ArabaEkleme : Form
    {
        public ArabaEkleme()
        {
            InitializeComponent();
        }
        RentDataContext context = new RentDataContext();
        private void btn_markaKaydet_Click(object sender, EventArgs e)
        {
            ArabaMarka marka = new ArabaMarka()
            {
                Marka = txt_marka.Text,
                Model=txt_arabaModel.Text
            };
            context.ArabaMarkas.Add(marka);
            context.SaveChanges();
            MessageBox.Show("Marka Eklendi");
            listele();
            
        }

        private void btn_MarkaDuzelt_Click(object sender, EventArgs e)
        {
            int secili = int.Parse(data_marka.CurrentRow.Cells[0].Value.ToString());
            ArabaMarka markalar = context.ArabaMarkas.First(u => u.id == secili);
            markalar.Marka= txt_marka.Text;
            markalar.Model= txt_arabaModel.Text;
            context.SaveChanges();
            MessageBox.Show("Güncellendi");
            listele();
        }
        void GridDoldur()
        {
            if (data_marka.Rows.Count > 0)
            {
                txt_marka.Text = data_marka.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_arabaModel.Text = data_marka.CurrentRow.Cells[2].Value.ToString().Trim();
            }


        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            int secili = int.Parse(data_marka.CurrentRow.Cells[0].Value.ToString());
            ArabaMarka markalar = context.ArabaMarkas.First(u => u.id == secili);
            context.ArabaMarkas.Remove(markalar);
            context.SaveChanges();
            MessageBox.Show("Silindi");
            listele();
        }

        private void data_marka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridDoldur();
        }

        private void ArabaEkleme_Load(object sender, EventArgs e)
        {
            this.arabaMarkasTableAdapter.Fill(this.nYPProjemDataSet.ArabaMarkas);
            listele();
            listeleAraba();
        }
        
        void listele()
        {
            var cek = from t in context.ArabaMarkas
                      select new
                      {
                          id = t.id,
                          araba_marka = t.Marka,
                          Model = t.Model
                      };
            data_marka.DataSource = cek.ToList();
            data_marka.Invalidate();
        }
        void temizle()
        {
            txt_arabaModel.Text = "";
            txt_kapi.Text = "";
            txt_marka.Text = "";
            txt_renk.Text = "";
            txt_tur.Text = "";
            txt_yili.Text = "";
            
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            ArabaEkle arabaEkle = new ArabaEkle()
            {
                ArabaKapiSayi = txt_kapi.Text,
                ArabaMarkasi = combo_marka.Text,
                ArabaModel=combo_model.Text,
                ArabaTuru=txt_tur.Text,
                ArabaRenk=txt_renk.Text,
                ArabaYili=int.Parse(txt_yili.Text)
            };
            context.ArabaEkles.Add(arabaEkle);
            context.SaveChanges();
            MessageBox.Show("Eklendi");
            listeleAraba();
            temizle();
        }

        private void btn_duzelt_Click(object sender, EventArgs e)
        {
            int secili = int.Parse(data_araba.CurrentRow.Cells[0].Value.ToString());
            ArabaEkle markalar = context.ArabaEkles.First(u => u.id == secili);
            markalar.ArabaKapiSayi = txt_kapi.Text;
            markalar.ArabaMarkasi = combo_marka.SelectedValue.ToString();
            markalar.ArabaModel = combo_model.SelectedValue.ToString();
            markalar.ArabaRenk = txt_renk.Text;
            markalar.ArabaTuru = txt_tur.Text;
            markalar.ArabaYili = int.Parse(txt_yili.Text);
            context.SaveChanges();
            MessageBox.Show("Güncellendi");
            listeleAraba();
            temizle();
        }

        private void btn_arabaSil_Click(object sender, EventArgs e)
        {
            int secili = int.Parse(data_araba.CurrentRow.Cells[0].Value.ToString());
            ArabaEkle markalar = context.ArabaEkles.First(u => u.id == secili);
            context.ArabaEkles.Remove(markalar);
            context.SaveChanges();
            MessageBox.Show("Silindi");
            listeleAraba();
            temizle();
        }
        void listeleAraba()
        {
            var cek = from t in context.ArabaEkles
                      select new
                      {
                          id = t.id,
                          ArabaMarkasi = t.ArabaMarkasi,
                          ArabaModel = t.ArabaModel,
                          ArabaRenk=t.ArabaRenk,
                          ArabaTur=t.ArabaTuru,
                          ArabaYil=t.ArabaYili,
                          ArabaKapi=t.ArabaKapiSayi
                      };
            data_araba.DataSource = cek.ToList();
            data_araba.Invalidate();
        }
        void GridDoldurAraba()
        {
            if (data_araba.Rows.Count > 0)
            {
                txt_kapi.Text = data_marka.CurrentRow.Cells[6].Value.ToString().Trim();
                txt_renk.Text = data_marka.CurrentRow.Cells[3].Value.ToString().Trim();
                txt_tur.Text= data_marka.CurrentRow.Cells[4].Value.ToString().Trim();
                txt_yili.Text= data_marka.CurrentRow.Cells[5].Value.ToString().Trim();
            }
        }
        private void data_araba_Click(object sender, EventArgs e)
        {
            GridDoldurAraba();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AnaSayfa a = new AnaSayfa();
            this.Hide();
            a.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NYPProje.Model.Context;
using NYPProje.Model.Data;
namespace NYPProje
{
    public partial class ArabaKiralama : Form
    {
        public ArabaKiralama()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txt_gun.Text = "";
            txt_gunluk.Text = "";
            txt_musteriAdi.Text = "";
            txt_musteriSoyadi.Text = "";
            txt_musteriTC.Text = "";
            date_ehliyet.Value = DateTime.Today;
            date_kayit.Value= DateTime.Today;
            date_musteriDT.Value = DateTime.Today;
        }
        RentDataContext context = new RentDataContext();
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            ArabaKirala kira = new ArabaKirala()
            {
                ArabaMarka = combo_arabaMarka.SelectedValue.ToString(),
                GunSayisi = int.Parse(txt_gun.Text),
                KayitTarihi = date_kayit.Value.ToString(),
                MusteriAdi = txt_musteriAdi.Text,
                MusteriDT = date_musteriDT.Value.ToString(),
                MusteriEhlyetTarih = date_ehliyet.Value.ToString(),
                MusteriSoyadi = txt_musteriSoyadi.Text,
                MusteriTC = txt_musteriTC.Text,
                Personel = combo_Personel.SelectedValue.ToString(),
                Ucret = int.Parse(txt_gunluk.Text) * int.Parse(txt_gun.Text)
            };
            context.ArabaKiralas.Add(kira);
            context.SaveChanges();
            MessageBox.Show("Kaydedildi");
            listele();
            temizle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int secili = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ArabaKirala ArabaKiralae = context.ArabaKiralas.First(u => u.id == secili);
            ArabaKiralae.ArabaMarka= combo_arabaMarka.SelectedValue.ToString();
            ArabaKiralae.GunSayisi = int.Parse(txt_gun.Text);
            ArabaKiralae.KayitTarihi = date_kayit.Value.ToString();
            ArabaKiralae.MusteriTC = txt_musteriTC.Text;
            ArabaKiralae.MusteriSoyadi = txt_musteriSoyadi.Text;
            ArabaKiralae.MusteriEhlyetTarih = date_ehliyet.Value.ToString();
            ArabaKiralae.Ucret = int.Parse(txt_gun.Text) * int.Parse(txt_gunluk.Text);
            ArabaKiralae.MusteriDT = date_musteriDT.Value.ToString();
            ArabaKiralae.Personel = combo_Personel.SelectedValue.ToString();
            ArabaKiralae.MusteriAdi = txt_musteriAdi.Text;
            context.SaveChanges();
            MessageBox.Show("Güncellendi");
            listele();
            temizle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int secili = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ArabaKirala kiralar= context.ArabaKiralas.First(u => u.id == secili);
            context.ArabaKiralas.Remove(kiralar);
            context.SaveChanges();
            MessageBox.Show("Silindi");
            listele();
            temizle();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AnaSayfa a = new AnaSayfa();
            this.Hide();
            a.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridDoldur();
        }

        private void ArabaKiralama_Load(object sender, EventArgs e)
        {
            this.personelsTableAdapter.Fill(this.nYPProjemDataSet2.Personels);
            this.arabaMarkasTableAdapter.Fill(this.nYPProjemDataSet1.ArabaMarkas);
            listele();
        }
        void GridDoldur()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txt_gun.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim(); 
                txt_musteriAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
                txt_musteriSoyadi.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
                txt_musteriTC.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim(); 
            }
        }
        void listele()
        {
            var cek = from t in context.ArabaKiralas
                      select new
                      {
                          İd = t.id,
                          Muşteri_TC = t.MusteriTC,
                          Muşteri_Adı = t.MusteriAdi,
                          Muşteri_Soyadı = t.MusteriSoyadi,
                          Ücret=t.Ucret,
                          Gun=t.GunSayisi,
                          Personel_Adı=t.Personel,
                          Araba_Marka=t.ArabaMarka
                      };
            dataGridView1.DataSource = cek.ToList();
            dataGridView1.Invalidate();
        }
    }
}

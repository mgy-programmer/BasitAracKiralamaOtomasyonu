using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NYPProje.Model.Context;
using NYPProje.Model.Data;

namespace NYPProje
{
    public partial class PersonelEkleme : Form
    {
        public PersonelEkleme()
        {
            InitializeComponent();
        }
        RentDataContext context = new RentDataContext();

        void temizle()
        {
            txt_Adres.Text = "";
            txt_email.Text = "";
            txt_Maas.Text = "";
            txt_PersonelAdi.Text = "";
            txt_PersonelSoyadi.Text = "";
            txt_TC.Text = "";
            data_DogumTarihi.Value = DateTime.Today;
            data_Kayit.Value = DateTime.Today;
        }
        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            try
            {
                Personel personel = new Personel()
                {
                    PersonelAdi = txt_PersonelAdi.Text,
                    PersonelAdres = txt_Adres.Text,
                    PersonelCinsiyet = combo_cinsiyet.Text,
                    PersonelDogumTarihi = data_DogumTarihi.Value.ToString(),
                    PersonelEmail = txt_email.Text,
                    PersonelKayitTarihi = data_Kayit.Value.ToString(),
                    PersonelMaas = txt_Maas.Text,
                    PersonelSoyadi = txt_PersonelSoyadi.Text,
                    PersonelTC = txt_TC.Text
                };
                context.Personels.Add(personel);
                context.SaveChanges();
                MessageBox.Show("Kaydedildi");
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Dikkatli Giriş Yapın");
            }
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int secili = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Personel personels = context.Personels.First(u => u.id == secili);
                personels.PersonelAdi = txt_PersonelAdi.Text;
                personels.PersonelSoyadi = txt_PersonelSoyadi.Text;
                personels.PersonelMaas = txt_Maas.Text;
                personels.PersonelTC = txt_TC.Text;
                personels.PersonelKayitTarihi = data_Kayit.Value.ToString();
                personels.PersonelEmail = txt_email.Text;
                personels.PersonelAdres = txt_Adres.Text;
                personels.PersonelCinsiyet = combo_cinsiyet.Text;
                personels.PersonelDogumTarihi = data_DogumTarihi.Value.ToString();
                context.SaveChanges();
                MessageBox.Show("Güncellendi");
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Güncellendi");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                int secili = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Personel personeller = context.Personels.First(u => u.id == secili);
                context.Personels.Remove(personeller);
                context.SaveChanges();
                MessageBox.Show("Silindi");
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
        void GridDoldur()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txt_PersonelAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_PersonelSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
                txt_TC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
                txt_Adres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim();
                txt_email.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
                txt_Maas.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim();
            }
        }
        void listele()
        {
            var cek = from t in context.Personels
                      select new
                      {
                          id = t.id,
                          PersonelAdı = t.PersonelAdi,
                          PersonelSoyadı=t.PersonelSoyadi,
                          PersonelTC=t.PersonelTC,
                          PersonelDT=t.PersonelDogumTarihi,
                          PersonelEmail=t.PersonelEmail,
                          PersonelAdres=t.PersonelAdres,
                          Maaş=t.PersonelMaas,
                          Tarih=t.PersonelKayitTarihi,
                          Cinsiyet=t.PersonelCinsiyet
                      };
            dataGridView1.DataSource = cek.ToList();
            dataGridView1.Invalidate();
        }

        private void PersonelEkleme_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AnaSayfa a = new AnaSayfa();
            this.Hide();
            a.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridDoldur();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
using System;
using System.Windows.Forms;
using NYPProje.Model.Data;
using NYPProje.Model.Context;

namespace NYPProje
{
    public partial class AdminIslemleri : Form
    {
        public AdminIslemleri()
        {
            InitializeComponent();
        }
        RentDataContext context = new RentDataContext();
        void temizle()
        {
            txt_email.Text = "";
            txt_kullaniciAdi.Text = "";
            txt_sifre.Text = "";
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin()
            {
                email = txt_email.Text,
                kullaniciAdi = txt_kullaniciAdi.Text,
                sifre = txt_sifre.Text
            };
            context.Admins.Add(ad);
            context.SaveChanges();
            MessageBox.Show("Eklendi");
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
    }
}

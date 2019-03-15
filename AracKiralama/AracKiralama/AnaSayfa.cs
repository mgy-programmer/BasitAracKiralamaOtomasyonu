using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPProje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            AdminIslemleri ad = new AdminIslemleri();
            this.Hide();
            ad.Show();
        }

        private void btn_ArabaKiralama_Click(object sender, EventArgs e)
        {
            ArabaKiralama araba = new ArabaKiralama();
            this.Hide();
            araba.Show();
        }

        private void bt_ArabaEkle_Click(object sender, EventArgs e)
        {
            ArabaEkleme arabaEkleme = new ArabaEkleme();
            this.Hide();
            arabaEkleme.Show();
        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
            PersonelEkleme personelEkleme = new PersonelEkleme();
            personelEkleme.Show();
            this.Hide(); 
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

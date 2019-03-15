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

namespace NYPProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RentDataContext context = new RentDataContext();

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_kullaniciAdi.Text == "Muhammed" && txt_sifre.Text == "12345")
            {
                AnaSayfa a = new AnaSayfa();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

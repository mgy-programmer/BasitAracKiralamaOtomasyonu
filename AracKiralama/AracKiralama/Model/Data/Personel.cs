using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPProje.Model.Data
{
    class Personel
    {
        public int id { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string PersonelTC { get; set; }
        public string PersonelAdres { get; set; }
        public string PersonelMaas { get; set; }
        public string PersonelCinsiyet { get; set; }
        public string PersonelDogumTarihi { get; set; }
        public string PersonelKayitTarihi { get; set; }
        public string PersonelEmail { get; set; }
    }
}

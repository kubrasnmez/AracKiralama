using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.ViewModel
{
    public class RaporMusteriVM
    {
        public string PlakaNo { get; internal set; }
        public DateTime KiraBaslangic { get; internal set; }
        public DateTime KiraBitis { get; internal set; }
        public int KiraGun { get; internal set; }
        public double OdemeTutar { get; internal set; }
        public string MusteriAd { get; internal set; }
        public string MusteriSoyad { get; internal set; }
        public string MusteriAdres { get; internal set; }
        public string MusteriTelNo { get; internal set; }
        public string MusteriEmail { get; internal set; }
        public DateTime MusteriDogumTarih { get; internal set; }
    }
}

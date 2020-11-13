using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Entity;
using AracKiralama.Enums;

namespace AracKiralama.ViewModel
{
    public class RaporAracVM
    {
        public string PlakaNo { get; internal set; }
        public DateTime BaslangicTarih { get; internal set; }
        public DateTime BitisTarih { get; internal set; }
        public int KiraGun { get; internal set; }
        public double ToplamTutar { get; internal set; }
        public string Marka { get; internal set; }
        public int RuhsatNo { get; internal set; }
        public DateTime SigortaTarih { get; internal set; }
        public string MusteriTC { get; internal set; }
        public string MusteriAd { get; internal set; }
        public string MusteriSoyad { get; internal set; }
        public string MusteriTel { get; internal set; }
        public DateTime MusteriDogumTarihi { get; internal set; }
    }
}

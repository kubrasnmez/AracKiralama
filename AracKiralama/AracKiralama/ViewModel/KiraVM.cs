using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.ViewModel
{
    public class KiraVM
    {
        public Guid Id { get; internal set; }
        public string PlakaNo { get; internal set; }
        public string MusteriTC { get; internal set; }
        public DateTime BaslangicTarih { get; internal set; }
        public DateTime BitisTarih { get; internal set; }
        public DateTime KiraSaat { get; internal set; }
        public int KiraUcret { get; internal set; }
        public int KiraGun { get; internal set; }
        public bool Hasar { get; internal set; }
        public string HasarDetay { get; internal set; }
        public int HasarTutar { get; internal set; }
        public double ToplamTutar { get; internal set; }
        public string Marka { get; internal set; }
        public string Renk { get; internal set; }
    }
}

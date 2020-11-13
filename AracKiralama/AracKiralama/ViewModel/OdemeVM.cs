using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Enums;

namespace AracKiralama.ViewModel
{
    public class OdemeVM
    {
        public Guid Id { get; internal set; }
        public string PlakaNo { get; internal set; }
        public string MusteriTc { get; internal set; }
        public DateTime BaslangicTarih { get; internal set; }
        public DateTime BitisTarih { get; internal set; }
        public int ToplamGun { get; internal set; }
        public double ToplamTutar { get; internal set; }
        public string Marka { get; internal set; }
    }
}

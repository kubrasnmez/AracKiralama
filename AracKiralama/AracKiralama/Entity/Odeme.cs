using AracKiralama.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entity
{
    [Table("Odemeler")]
    public class Odeme:BaseEntity
    {
        public Odeme()
        {
            Id = Guid.NewGuid();
        }

        public string PlakaNo { get; set; }
        public string MusteriTC { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        public int KiraGun { get; set; }
        public double ToplamTutar { get; set; }
        public string Marka { get; set; }

    }
}

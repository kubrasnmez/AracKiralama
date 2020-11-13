using AracKiralama.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entity
{
    [Table("Kiralar")]
    public class Kira:BaseEntity
    {
        public Kira()
        {
            Id = Guid.NewGuid();
        }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
        public DateTime Sure { get; set; }
        public int Ucret { get; set; }
        public bool Hasar { get; set; }
        public string Hasar_durum { get; set; }

        public int KiraGun { get; set; }
        
        public int Hasar_tutar { get; set; }
        public double Toplam_tutar { get; set; }

        public string Marka { get; set; }
        public string Renk { get; set; }

        public Guid MusteriId { get; set; }
        public Guid AracId { get; set; }

        [ForeignKey("MusteriId")]
        public virtual Musteri Musteri { get; set; }

        [ForeignKey("AracId")]
        public virtual Arac Arac { get; set; }
       

    }
}

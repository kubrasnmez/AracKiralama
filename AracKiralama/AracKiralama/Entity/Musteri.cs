using AracKiralama.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entity
{
    [Table("Musteriler")]
    public class Musteri:BaseEntity
    {
        public Musteri()
        {
            Id = Guid.NewGuid();
        }
        public string MusteriTC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Telno { get; set; }
        public DateTime DogumTarih { get; set; }
        public string Email { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public int Ehliyetno { get; set; }
        public virtual List<Kira> Kiralar { get; set; }
    }
}

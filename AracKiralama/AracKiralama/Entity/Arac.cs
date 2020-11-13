using AracKiralama.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entity
{
    [Table("Araclar")]
    public class Arac:BaseEntity
    {
        public Arac()
        {
            Id = Guid.NewGuid();
        }
        public string Plakano { get; set; }
        
        public YakitTipi YakipTipi { get; set; }
        public DateTime SigortaTarihi { get; set; }
        public int Ruhsatno { get; set; }
        public Renk Renk { get; set; }
        public VitesTipi VitesTipi { get; set; }
        public int Kilometre { get; set; }
        public bool KiraDurum { get; set; }
        public Guid ModelId { get; set; }
        public Guid TipId { get; set; }

        [ForeignKey("ModelId")]
        public virtual Model Model { get; set; }

        [ForeignKey("TipId")]
        public virtual Tip Tip { get; set; }


        

        public virtual List<Kira> Kiralar { get; set; }
    }
}


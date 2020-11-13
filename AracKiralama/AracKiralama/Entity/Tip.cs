using AracKiralama.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entity
{
    [Table("Tipler")]
    public class Tip:BaseEntity
    {
        public Tip()
        {
             Id = Guid.NewGuid();
        }
        public string AracTipi { get; set; }

        public virtual List<Arac> Araclar { get; set; }
    }
}

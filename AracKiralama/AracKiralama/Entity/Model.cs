using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entity
{
    [Table("Modeller")]
    public class Model:BaseEntity
    {
        public Model()
        {
            Id = Guid.NewGuid();
        }
        public string Name { get; set; }

        public Guid MarkaId { get; set; }

        [ForeignKey("MarkaId")]
        public virtual Marka Marka { get; set; }
        public virtual List<Arac> Araclar { get; set; }
    }
}

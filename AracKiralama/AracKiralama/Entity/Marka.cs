using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entity
{
    [Table("Markalar")]
    public class Marka:BaseEntity
    {
        public Marka()
        {
            Id = Guid.NewGuid();
        }
        public string Name { get; set; }

        public virtual List<Model> Modeller { get; set; }
    }
}

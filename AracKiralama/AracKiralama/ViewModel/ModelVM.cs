using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.ViewModel
{
    public class ModelVM
    {
        public Guid Id { get; internal set; }
        public string Model_isim { get; internal set; }
        public string Marka_isim { get; internal set; }
    }
}

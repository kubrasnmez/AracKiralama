using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Enums;

namespace AracKiralama.ViewModel
{
    public class AracVM
    {
        public Guid Id { get; internal set; }
        public string Plaka { get; internal set; }
        public string Marka { get; internal set; }
        public string Model { get; internal set; }
        
        public string Tip { get; internal set; }
        public Renk Renk { get; internal set; }
        public VitesTipi VitesTipi { get; internal set; }
        public int Kilometre { get; internal set; }
        public YakitTipi YakitTipi { get; internal set; }
        public DateTime SigortaTarih { get; internal set; }
        public int RuhsatNo { get; internal set; }
        public bool KiraDurum { get; internal set; }
    }
}

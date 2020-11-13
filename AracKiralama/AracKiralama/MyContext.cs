using AracKiralama.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama
{
    class MyContext:DbContext
    {
        public MyContext() : base("name=MyCon")
        {

        }
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Model> Modeller { get; set; }
        public DbSet<Tip> Tipler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Kira> Kiralar { get; set; }
        public DbSet<Odeme> Odemeler { get; set; }
        
    }
}

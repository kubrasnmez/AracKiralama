using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Enums;

namespace AracKiralama.ViewModel
{
    public class MusteriVM
    {
        public Guid Id { get; internal set; }
        public string TcKimlik { get; internal set; }
        public string Ad { get; internal set; }
        public string Soyad { get; internal set; }
        public string TelefonNo { get; internal set; }
        public string Email { get; internal set; }
        public string Adres { get; internal set; }
        public int EhliyetNo { get; internal set; }
        public Cinsiyet Cinsiyet { get; internal set; }
        public DateTime DogumTarih { get; internal set; }
    }
}

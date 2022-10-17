using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine($"Sepete Eklendi! : {urun.Adi}");
        }

        //public void Ekle2(string urunAdi, string aciklama, double fiyati, int stokAdedi)
        //{
        //  Console.WriteLine("Tebrikler! Ürün Sepete Eklendi : " + urunAdi);
        //}
        
    }
}
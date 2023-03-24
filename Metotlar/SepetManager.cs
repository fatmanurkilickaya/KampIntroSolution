using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Sepete eklendi, tebrikler : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, double fiyat, string aciklama, int StokAdedi)
        {
            Console.WriteLine("Sepete eklendi, tebrikler : " + urunAdi);
        }
    }
}

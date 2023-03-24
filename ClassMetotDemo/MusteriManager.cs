using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
     class MusteriManager
     {
        public void MusteriEkle(Musteri musteri) { 

            Console.WriteLine(musteri.Name+ " " + musteri.Surname+ "isimli müşteri sisteme eklenmiştir.");
        }

        public void MusteriSil(Musteri musteri) {

            Console.WriteLine(musteri.Id + "id numaralı müşteri sistemden silinmiştir.");
        }

        public void MusteriGuncelle(Musteri musteri) {
            Console.WriteLine(musteri.Id + "id numaralı müşterinin bilgileri güncellenmiştir.");
        }    

     }
}

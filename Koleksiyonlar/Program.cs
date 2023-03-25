using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Kübra", "Hilal", "Cuma", "Merve", "Miray", "Nur" };

            isimler = new string[7];
            isimler[6] = "Maya"; //diziler de array kullandığım da yeni isim eklemek istediğimde diğerleri gelmedi. Çünkü new'lediğimde bellekte(heap) yeni bir referans numarası olan alan oluşturdu.

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);

            }
            // array yerine koleksiyon kullanılır

            List<string> isimler2 = new List<string> { "Kübra", "Hilal", "Cuma", "Merve", "Miray", "Nur" };

            isimler2.Add("Maya");

            for (int i = 0; i < isimler2.Count; i++)
            {
               Console.WriteLine(isimler2[i]);

            }

        }
    }
}
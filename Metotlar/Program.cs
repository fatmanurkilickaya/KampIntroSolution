namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // clean code- best practice


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 6.4;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 3;


            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 8;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            // type-safe -- tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("................");
            }

            Console.WriteLine("--------Metotlar-----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle2("Armut", 12, "Yeşil",9);



        }
    }
}
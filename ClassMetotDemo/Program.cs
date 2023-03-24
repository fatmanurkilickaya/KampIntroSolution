namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Nur";
            musteri1.Surname = "Matilda";
            musteri1.Age = 30;
            musteri1.City = "Kayseri";

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Maya";
            musteri2.Surname = "Nur";
            musteri2.Age = 30;
            musteri2.City = "Aksaray";



            MusteriManager musteriler = new MusteriManager();
            musteriler.MusteriEkle(musteri1);
            musteriler.MusteriSil(musteri2);
            musteriler.MusteriGuncelle(musteri1);
        }
    }
}
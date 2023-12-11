using Metotlar;
using System.Security.Permissions;

internal class Program
{
    private static void Main(string[] args)
    {
       Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Aciklama = "Amasya elmasi";
        urun1.Fiyati = 15;

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 85;
        urun2.Aciklama = "Diyarbakir Karpuzu";

        Urun[] urunler = new Urun[] { urun1, urun2 };
        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("------------");
        }
        Console.WriteLine("---------------");
        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);











    }
}
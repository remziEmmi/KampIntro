internal class Program
{
    private static void Main(string[] args)
    {
         
        Console.WriteLine("Hello, World!");
        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin";
        kurs1.IzlenmeOran = 12;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Remzi";
        kurs2.IzlenmeOran = 187;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Ornek";
        kurs3.Egitmen = "Ornek";
        kurs3.IzlenmeOran = 12222;  
        Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
        foreach (var item in kurslar)
        {
            Console.WriteLine(item.KursAdi);
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOran { get; set; }
        public int Sayisi { get; set; }
    }
}
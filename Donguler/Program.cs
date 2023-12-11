internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
       {
            Console.WriteLine("sart calisiyor");

       }
        string[] kurslar = new string[] { "Ornek1", "Ornek2", "Ornek3","Ornek4" };
        int[] sayilar = new int[]
        {
            1,2,3,4,5,5
        };
        for (int i = 0;i <kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("==================================================");
        Console.WriteLine("Sayfa Sonu");
        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }
    }
}
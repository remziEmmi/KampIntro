internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int sayi1 = 10;
        int sayi2 = 20;
        sayi1 = sayi2;
        sayi2 = 60;
        //sayi 1 kactir cevap 30 stack den geliyor
        int[] sayilar1 = new int[] { 10, 20, 30 };
        int[] sayilar2 = new int[] { 100, 200, 300 };
        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        //sayilar1[0] kactir cevap 999 heapden geliyor 
        
    }
}
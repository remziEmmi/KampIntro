internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Product urun1 = new Product();
        urun1.Name = "Car";
        urun1.Price = 100;
        urun1.Stocks = 10;
        Product urun2 = new Product();
        urun2.Name = "Box";
        urun2.Price = 102;
        urun2.Stocks = 1;
        Product[] urunler = new Product[] { urun1,urun2};

        foreach (Product x in urunler)
        {
            Console.WriteLine(x.Name+" "+x.Price);
        }
        Console.WriteLine("FOR EACH BITTI------------------------------");
        for (int i = 0; i < urunler.Length; i++)
        {
            Console.WriteLine("Product" + urunler[i].Name);
        }
        Console.WriteLine("FOR BITI--------------------------");
        int sart = 0;
        while (sart<urunler.Length)
        {
            Console.WriteLine("Product" + urunler[sart].Name);
            sart++;
            Console.WriteLine("While Bitti---------------------------------");
        }
    }
    class Product
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public int Stocks { get; set; }

    }
}
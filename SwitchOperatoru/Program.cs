internal class Program
{
    private static void Main(string[] args)
    {
        int x = 10;
        switch (x)
        {
            case 10:
                Console.WriteLine("10");
                break;
            case 20:
                Console.WriteLine("wqeqwe");
                break;
                case 30 goto case 10;
               

                
            
        }
        Console.WriteLine("Hello, World!");
    }
}
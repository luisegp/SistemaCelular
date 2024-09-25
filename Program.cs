using ProjetoC_.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("123456", "Nokia 3310", "111111111", 32);
        Console.WriteLine($"Modelo do celular: {nokia.Modelo}");
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine();

        Iphone iphone = new Iphone("987654", "iPhone 14", "222222222", 128);
        Console.WriteLine($"Modelo do celular: {iphone.Modelo}");
        iphone.InstalarAplicativo("Instagram");
    }
}

class Program { 
    static void Main()
    {
        topla();
    }
    static void topla()
    {
        Console.WriteLine("Merhaba herkese");
        Console.WriteLine("planımız şu şekilde...");
        Console.WriteLine("ilk sayıyı girin: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ikinci sayıyı girin: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int toplam = a + b;
        Console.WriteLine($"toplam:{toplam}");
    }
}


static async Task Main(string[] args)
{
    while (true)
    {
        Console.WriteLine("=== E-COMMERCE CONCURRENCY & DI ENGINE ===\r\n");
        Console.WriteLine("1. Yeni Sifariş Əlavə Et (Async)");
        Console.WriteLine("2. Dependency Injection İlə Bildiriş Göndərməni Test Et");
        Console.WriteLine("3. Sifarişləri Paralel Emal Et (Race Condition & Lock Testi)\r\n");
        Console.WriteLine("4. Sifarişləri JSON Faylına Saxla (Async Streams & Using)\r\n");
        Console.WriteLine("5. Fayldan Sifarişləri Oxu(Deserialization)\r\n");
        Console.WriteLine("6. Sifariş Obyektini Reflection İlə İnspeksiya Et\r\n");
        Console.WriteLine("7. Record və Deep Copy Testi\r\n");
        Console.WriteLine("0. Çıxış");
    }
}
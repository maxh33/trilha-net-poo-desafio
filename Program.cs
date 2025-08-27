using DesafioPOO.Models;

Console.WriteLine("=== Teste com Nokia ===");
Nokia nokia = new Nokia("(11) 99999-1234", "Nokia 3310", "111111111111111", 64);
Console.WriteLine($"Número: {nokia.Numero}");
Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"IMEI: {nokia.IMEI}");
Console.WriteLine($"Memória: {nokia.Memoria}GB");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();
Console.WriteLine("=== Teste com iPhone ===");
Iphone iphone = new Iphone("(11) 88888-5678", "iPhone 14", "222222222222222", 256);
Console.WriteLine($"Número: {iphone.Numero}");
Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"IMEI: {iphone.IMEI}");
Console.WriteLine($"Memória: {iphone.Memoria}GB");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
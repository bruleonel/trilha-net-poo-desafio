using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// OK

Console.WriteLine("SMARTPHONE NOKIA:");
Smartphone g21 = new Nokia("98999-0000", "G21", "12131415161718", 128);
g21.Ligar();
g21.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("SMARTPHONE IPHONE:");
Smartphone proMax = new Nokia("99992-0000", "Pro Max", "12121414161617", 256);
proMax.ReceberLigacao();
proMax.InstalarAplicativo("Telegram");

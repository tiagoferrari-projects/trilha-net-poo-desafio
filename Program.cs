using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Teste Nokia
Nokia nokia = new Nokia("123456", "IMEI123", "Nokia Model", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

// Teste Iphone
Iphone iphone = new Iphone("789123", "IMEI456", "iPhone Model", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.ReadLine();
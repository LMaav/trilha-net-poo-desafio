using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine($"Nokia: ");
Smartphone nokia = new Nokia(numero: "13996534920", modelo: "LXHFY27C5T3X1", imei: "1111", memoria: 24);
nokia.Ligar();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine("\n");

Console.WriteLine($"Iphone: ");
Smartphone iphone = new Iphone(numero: "1197764922", modelo: "A5HN428C5T3XT", imei: "2222", memoria: 16);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twiiter");
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "modelo 1100", imei: "012345678-9", memoria: 32);
nokia.Ligar();
nokia.Apresentar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "54321", modelo: "modelo 14", imei: "098765432-1", memoria: 128);
iphone.ReceberLigacao();
iphone.Apresentar();
iphone.InstalarAplicativo("Youtube");
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "98765", modelo: "E-51", imei: "nk123456", memoria: 5);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("-------------");
Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "11112222333", modelo: "Iphone 13X", imei: "iph50002000", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Safari");


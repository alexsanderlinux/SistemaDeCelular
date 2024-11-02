using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Android e Iphone //feito

Console.WriteLine("Smartphone Samsung: ");
Smartphone samsung = new Android(numero: "10101010", modelo: "S23Fe", imei: "101010102020202020", memoria: 256);
samsung.Ligar();
samsung.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "30303030", modelo: "iphone SE", imei: "451523696312852236", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "98128293", modelo: "Modelo 1", imei: "113113131", memoria: 320);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "09329094", modelo: "Modelo 2", imei: "224333222", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
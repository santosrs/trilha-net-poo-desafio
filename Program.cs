using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphoneusing System;

Console.Clear();

// Criando instância de Nokia
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "111111111111111", memoria: 32);
Console.WriteLine("### Testando Nokia ###");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

// Criando instância de Iphone
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 13", imei: "222222222222222", memoria: 128);
Console.WriteLine("### Testando iPhone ###");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

       

using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new  Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64); 
nokia.Ligar();
nokia.InstalarAplicativo("whatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new  Iphone(numero: "789456", modelo: "Modelo 10", imei: "3333333", memoria: 128); 
iphone.ReceberLigacao();
iphone.InstalarAplicativo("whatsApp");

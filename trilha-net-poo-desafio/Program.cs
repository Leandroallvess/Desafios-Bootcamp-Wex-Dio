using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone Nokia = new Nokia(numero: "99-9999-9999", modelo: "Modelo 1", imei: "234565", memoria: 128);
Console.WriteLine(" Dados do meu Smartphone Nokia");
Console.WriteLine(Nokia.Memoria);
Console.WriteLine(Nokia.IMEI);
Console.WriteLine(Nokia.Numero);
Console.WriteLine(Nokia.Memoria);
Nokia.Ligar();
Nokia.InstalarAplicativo("Instagram");




Console.WriteLine("/n-------------------------------------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone(numero: "00-0000-0000", modelo: "Modelo 16", imei: "212121", memoria: 256);
Console.WriteLine(" Dados do meu Smartphone Nokia");
Console.WriteLine(Iphone.Memoria);
Console.WriteLine(Iphone.IMEI);
Console.WriteLine(Iphone.Numero);
Console.WriteLine(Iphone.Memoria);
Iphone.Ligar();
Iphone.InstalarAplicativo("Telehram");


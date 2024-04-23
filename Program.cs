using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Celular Nokia");

Nokia c1 = new Nokia("21999999", "09092M", "LUMIA420", 8);
c1.Ligar();
c1.InstalarAplicativo("Subway Surfers\n");

System.Console.WriteLine("Celular Iphone");
Iphone c2 = new Iphone("2131424242", "23827G", "IPHONE 20", 120);
c2.ReceberLigacao();
c2.InstalarAplicativo("Flappy Bird\n");

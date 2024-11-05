using AtividadeClasses;

Console.Clear();
Console.WriteLine($"***Bem-vindo a minha loja de carros!***");
Console.WriteLine();

Veiculo Peugeot  = new veiculo ();


Console.WriteLine($"Qual é a marca do carro?");
Peugeot2008.marca = Console.ReadLine();

Console.WriteLine($"Qual é o modelo?");
Peugeot2008.Modelo = Console.ReadLine();

Console.WriteLine($"Qual é a cor?");
Peugeot2008.cor =Console.ReadLine();

Console.WriteLine($"Qual é a potência?");
Peugeot2008.potencia = Console.ReadLine();

Console.WriteLine($"Quantas portas?");
Peugeot2008.qtdPortas =Console.ReadLine();


Console.WriteLine(@$"Carro: {Peugeot2008 .marca} {Peugeot2008 .modelo}!");

Peugeot2008.Ligar();



Veiculo FordMustang = new veiculo ();

Console.WriteLine($"Qual é a marca do carro?");
 Ford Mustang.marca = Console.ReadLine();

 Console.WriteLine($"Qual é o modelo?");
 Ford Mustang.Modelo = Console.ReadLine();

Console.WriteLine($"Qual é a cor?");
 Ford Mustang.cor = Console.ReadLine();

Console.WriteLine($"Qual é a potência?");
 Ford Mustang.potencia = Console.ReadLine();

 Console.WriteLine($"Quantas portas?");
 Ford Mustang.qtdPortas = Console.ReadLine();

Console.WriteLine(@$"Carro: {FordMustang .marca} {FordMustang .modelo}!");
FordMustang.Ligar();


Veiculo BMW = new veiculo ();


Console.WriteLine($"Qual é a marca do carro?");
 Ford Mustang.marca = Console.ReadLine();

  Console.WriteLine($"Qual é o modelo?");
 Ford Mustang.Modelo = Console.ReadLine();

 Console.WriteLine($"Qual é a cor?");
 Ford Mustang.cor =Console.ReadLine();

 Console.WriteLine($"Qual é a potência?");
 Ford Mustang.potencia =  Console.ReadLine();

 Console.WriteLine($"Quantas portas?");
 Ford Mustang.qtdPortas = Console.ReadLine();


Console.WriteLine(@$"Carro: {BMW.marca} {BMW.modelo}!");

BMW.Ligar();






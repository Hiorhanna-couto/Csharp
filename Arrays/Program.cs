
string[] carros = new string[3];

Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
carros[0] = Console.ReadLine()!;

for (int i = 0; i < carros.Length; i++)


{
    Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
    carros[i] = Console.ReadLine()!;

}

Console.WriteLine($"O carro cadastrado é {carros[0]}, {carros[1]}, {carrosd[2]}");


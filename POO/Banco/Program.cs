   using Banco.Classes;

Console.Clear();
 Console.WriteLine($"Bem vindo ao inter");
 Console.WriteLine();
 
ContaCorrente contaHiorhanna = new ContaCorrente();
ContaCorrente contaEmilly = new ContaCorrente();

contaHiorhanna.Titular= "Hiorhanna";
contaHiorhanna.Depositar(1000000f);

contaEmilly.Titular= "Emilly";
contaEmilly.Depositar(10000f);

Console.WriteLine($"Conta da {contaEmilly.Titular} Tem R$ { contaEmilly.Saldo}");
Console.WriteLine($"Conta da {contaHiorhanna.Titular} Tem R$ { contaHiorhanna.Saldo}");

contaHiorhanna.Sacas(250f);

Console.WriteLine($"Você sacou e sua conta ficou com R${ contaEmilly.Saldo}");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine($"Conta da {contaEmilly.Titular }Tem R${contaEmilly.Saldo}");

Console.WriteLine($"Conta da {contaHiorhanna.Titular }Tem R${contaHiorhanna.Saldo}");


using PilaresPOO;
 Console.Clear();

ContaCorrente ctnana = new ContaCorrente();
ctnana.Titular = "^.^Hiorhanna Couto Santana(✿◡‿◡)";
ctnana.Deposita (50000000f);

Console.WriteLine($"Titular da Conta: {ctnana.Titular}");
Console.WriteLine($"Saldo da Conta: {ctnana.getSaldo()}");

float valorSacado = ctnana.Sacar ( 6.118920f);

Console.WriteLine($"Valor do Saque : {valorSacado}");
Console.WriteLine($"Novo Saldo : {ctnana.getSaldo()}");


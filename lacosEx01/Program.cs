Console.WriteLine(@$"
----------------------------------------
|         Bem vindo ao programa        |
|              Contador                |
|                 De                   |
|               Pessoas                |
----------------------------------------
");



int QtdMulher = 0;
int QtdHomem = 0;
int QtdEsporte =0;
Console.WriteLine($"Quanto pessoas tem na sua mesa?");
int qtdDeEntrevistado = int.Parse (Console.ReadLine()!);
int QtdNaoEsporte= 0;

for (int i = 0; i <= qtdDeEntrevistado; i++)
{


    Console.WriteLine($"Qual é o seu sexo ? m/f");
    string sexo = Console.ReadLine();
    if(sexo== "f"){
        QtdMulher++;
    }else{
        QtdHomem++;
    }


      Console.WriteLine($"Voces gosta de esporte?s/n");
      string esporte = Console.ReadLine();

       if(esporte=="s")
      {

     QtdEsporte ++;

    }
 
    else 
{
 QtdNaoEsporte ++;

}

}

float percentual = (100/ qtdDeEntrevistado)* QtdEsporte;



Console.WriteLine($"Quantidade de Mulheres : {QtdMulher}");
Console.WriteLine($"Quantidade de Homens : {QtdHomem}");
Console.WriteLine($"TOTAL DE ENTREVISTADOS : {QtdHomem + QtdMulher}");
Console.WriteLine($"Quantidade de pessoas que gostam de esporte: {QtdEsporte}");
Console.WriteLine($"Quantidade de pessoas que nao  gostam de esporte: {QtdNaoEsporte}");
Console.WriteLine($"Percentual de pessoas que gostam de esportes: {QtdNaoEsporte}%");


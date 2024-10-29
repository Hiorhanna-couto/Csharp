int homem = 0;
int mulher = 0;
float idadehomem = 0;
float idademulher = 0;

for (int n = 1; n <=4; n++)
{
    Console.WriteLine($"Qual sua idade?");
    float idade = float.Parse(Console.ReadLine());

    Console.WriteLine($"Qual seu peso:");
    float peso = float.Parse(Console.ReadLine());

    Console.WriteLine($"Qual seu sexo? m/f");
    string sexo = Console.ReadLine()!;
    
    
    if(sexo == "m")
    {
        homem ++;
        idadehomem += idade;
    }
    else 
    {
        mulher ++;
        idademulher += idade;
    }


}

float mediahomem = (idadehomem / homem);
float mediamulher = (idademulher / mulher);

Console.WriteLine($"Total de homens : {homem}");
Console.WriteLine($"Total de mulheres : {mulher}");
Console.WriteLine($"A media de idade de homens :{mediahomem}");
Console.WriteLine($"A media de idade de mulheres :{mediamulher}");

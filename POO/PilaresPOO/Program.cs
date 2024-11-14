using PilaresPOO.Classes.Aprendizagem;

Aluno joao = new Aluno();
joao.Nome ="joao";

Console.WriteLine($"{ joao.Nome} Nasceu com { joao.idade} anos");

Professor sam = new Professor(123321);
sam.Nome ="Samanta";
sam.idade = 22;

Aluno felipeHolan = new Aluno();

felipeHolan.Nome = "Felipe Holan couto santana";
felipeHolan.idade = 2;
felipeHolan.Matricula = 13378352;
felipeHolan.curso = "Dev";
felipeHolan.media = 7.9f;


Console.WriteLine($"Curso :  { felipeHolan.curso}");
Console.WriteLine($"  PROFESSOS : {sam.Nome}");
Console.WriteLine($"    IDADE DA Professora {sam.idade}");
Console.WriteLine($"        Identificacao do Professor : { sam.NiF}");





Console.WriteLine($"Aluno : { felipeHolan.Nome}");
Console.WriteLine($" idade : { felipeHolan.idade}");
Console.WriteLine($"Matricula : { felipeHolan.Matricula}");
Console.WriteLine($"Curso :  { felipeHolan.curso}");
Console.WriteLine($"Media :  { felipeHolan.media}");

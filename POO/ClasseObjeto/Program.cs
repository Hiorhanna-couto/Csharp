using ClasseObjeto.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo ao programa Zoosharp **");
Console.WriteLine();

Animal cachorrinho = new Animal ();

cachorrinho.Nome = "luna";
cachorrinho.Cor = "Branca e marrom";
cachorrinho.idade = 2;
cachorrinho.raca = " American bully";

Animal cachorrinhodabrito = new Animal ();

cachorrinhodabrito.Nome ="Max";
cachorrinhodabrito.Cor ="Branco";
cachorrinhodabrito.raca ="poodle";
cachorrinhodabrito.idade = 4;


Animal peixeDokaue = new Animal ();

peixeDokaue.Nome = "Anna";
peixeDokaue.Cor = "Amarelo";
peixeDokaue.raca = "Telescopio";
peixeDokaue.idade = 17;



// Console.WriteLine(@$"Animal 1:

//  Nome : {cachorrinho.Nome}
//  raca : {cachorrinho.raca}
//  Cor : {cachorrinho.Cor}
//  Idade: {cachorrinho.idade}


// ");

// Console.WriteLine(@$"Animal 2:

//  Nome : {cachorrinhodabrito.Nome}
//  raca : {cachorrinhodabrito.raca}
//  Cor : {cachorrinhodabrito.Cor}
//  Idade: {cachorrinhodabrito.idade}


// ");

// Console.WriteLine(@$"Animal 3:

//  Nome : {peixeDokaue.Nome}
//  raca : {peixeDokaue.raca}
//  Cor : {peixeDokaue.Cor}
//  Idade: {peixeDokaue.idade}


// ");

cachorrinho.FazerBarulho("au au ");
Console.WriteLine($"idada de {cachorrinho.Nome} e {cachorrinho.idade}");

cachorrinho.Envelhecer();
Console.WriteLine($" Nova idada de {cachorrinho.Nome} e {cachorrinho.idade}");


cachorrinhodabrito.FazerBarulho("ow ow ");
Console.WriteLine($"idada de {cachorrinhodabrito.Nome} e {cachorrinhodabrito.idade}");

peixeDokaue.FazerBarulho ( "glu glu");
Console.WriteLine($"idada de {peixeDokaue.Nome} e {peixeDokaue.idade}");








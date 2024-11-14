

namespace CONTRUTORES.Classes
{
    public class Jogos
    {
        public string Nome { set ; get; }

        public int Lancamento {get; set; }
        public string Genero  {get; set; }
        public float Preso {get; set ;}


 public Jogos ( string nome , int lancamento ,string genero , float preso ){

 Nome = nome;
 Lancamento = lancamento;
Genero = genero;
 Preso   = preso;
 




    }

public void  ExibirDados(){ 

Console.WriteLine($@"

Nome do Jogor : {Nome }
Ano do lancamento: {Lancamento}
genero : { Genero}
 preso do jogos { Preso }
");













}
}
}
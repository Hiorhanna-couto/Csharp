

namespace CONTRUTORES.Classes
{
    public class Aluno
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Matricula { get; set; }


        public Aluno(string nome, int idade, string matricula)
        {
            Nome = nome;
            Idade = idade;
            Matricula = matricula;
        }



        public void ExibirDados()
        {

            Console.WriteLine($@"

Nome do Aluno : {Nome}
idada do Aluno : {Idade}
matricula : {Matricula}

");


        }



    }
}

namespace ClasseObjeto.Classes
{
    public class Animal
    {
        public String Nome;
        public String Cor;
        public String raca;
        public int idade = 0;


        public void FazerBarulho(string barulho = "Barulhos generico" ){

           Console.WriteLine($"Som de um animal: {barulho}");


        }
        
       public void Envelhecer(){
        
        idade = idade + 1;


       }




        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public   abstract class Pessoas 
    {
      public string Nome;

      public int idade;

      public string CPF;

      public float peso { get ; set ;}
      public float Altura { get ; set ;}
       


    public void Envelhecer (){

    idade ++ ;


    }

public void Engordar( float _kg){

peso = peso + _kg;

}

public void Emagrecer ( float _kg){

peso = peso - _kg;


}



        
    }
}
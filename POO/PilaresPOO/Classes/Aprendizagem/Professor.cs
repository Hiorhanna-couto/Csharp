using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Professor : Pessoas
    {
        

       public int NiF { get;set;}
    public int Salario { get;set;}

    public Professor (int _nif){

        NiF = _nif;
    }


    }
}
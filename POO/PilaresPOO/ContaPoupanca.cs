using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO 
{
    public class ContaPoupanca : Conta
    {
            public int LimiteSaque {get; set;}
            public float rendimento {get; set;}

         


        public override bool Deposita(float valor)
        {
            throw new NotImplementedException();
        }

        public override float Sacar(float valor)
        {
            throw new NotImplementedException();
        }
    }
}
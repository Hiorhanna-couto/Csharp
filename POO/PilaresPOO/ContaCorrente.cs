using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO 
{
    public class ContaCorrente : Conta
    {

            public int Limite {get; set;}
          
        public bool Transferir (float volor , Conta contaDestino){


         return false;


        }

        public override bool Deposita(float valor)
        {
           Saldo = Saldo + valor ;
             return true;
        }

        public override float Sacar(float valor)
        {
           Saldo = Saldo - valor;
            return valor;
        }
    }
}
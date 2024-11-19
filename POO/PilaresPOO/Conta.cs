using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO
{
    public abstract class Conta
    {
    protected float Saldo {get; set;}

    public string? Titular {get; set;}

     public abstract float Sacar (float valor);
     public abstract bool Deposita (float valor);

     public float getSaldo(){

      return Saldo;


     }






    // public void BotaSaldoAI(float grana){

    //   Saldo = grana;

    // }
    // public float DevolveSaldoAI(){

    //  return Saldo;

    // }





    }
}
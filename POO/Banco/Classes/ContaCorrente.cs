using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.Classes
{
    public class ContaCorrente
    {
      public int NumeroConta;

     public string ? Titular;

     public float Saldo = 0f;

     
public void Depositar (float  Valor )

{

Saldo = Saldo + Valor;

}

public void Sacas ( float valor)

{
   Saldo = Saldo - valor;


}



    }
}
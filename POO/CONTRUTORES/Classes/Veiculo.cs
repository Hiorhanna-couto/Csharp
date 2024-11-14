

namespace CONTRUTORES.Classes
{
  public class Veiculo
  {
    public string marca { get; set; }

    public string modolo { get; set; }

    public int ano { get; set; }

    public string cor { get; set; }

    public Veiculo(string ma, string md, int an, string cr)
    {

      marca = ma;
      modolo = md;
      ano = an;
      cor = cr;


    }

    public void ExibirDados()
    {

      Console.WriteLine(@$"
          
         Marca: {marca}
         Modelo: {modolo}
         Ano:{ano}
         Cor : {cor}

         ");


    }


  }
}

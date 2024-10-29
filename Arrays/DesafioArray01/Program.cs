Console.WriteLine(@"
+---------------------------------------------+
|            PROGRAMA DE CADASTROS            |
+                                             +
|      Por favor digite seus dados abaixo     |
+---------------------------------------------+

");

int [] numeros = new int[6];
int impar = 0;
int par = 0;

for (int i = 0; i < 6; i++) {
 
Console.WriteLine($"Digite um numero inteiro:");
int numeros[i] = int.Parse(Console.ReadLine());
 

if (numeros [i] % 2 == 0){
par++;

 }else {

    impar++;
 }

}

Console.WriteLine($"{impar} numero(s) impar(es):");
for (int i = 0; i < numeros.length; i++)
{
   if (numeros[i]% 2 == 0)
   {
       Console.WriteLine($"{numeros[i]}");
   }

   
}

Console.WriteLine();
Console.WriteLine();// pula uma linha

Console.WriteLine($"{par} numero(s) par(es):");
for (int i = 0; i < numeros.length; i++)
{
   if (numeros[i]% 2 == 1)
   {
      Console.WriteLine($"{numeros[i]}");
      
   }


}
Console.WriteLine();
Console.WriteLine();//pula uma linha

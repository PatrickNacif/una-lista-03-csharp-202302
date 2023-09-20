using System;
public class Program
{
  public static void Main()
  {
    double n1, n2, n3; // Declaração de variável.
    Console.WriteLine("Digite o primeiro número: ");
    n1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    n2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o terceiro número: ");
    n3 = Convert.ToDouble(Console.ReadLine());

    double maior = n1;
    double menor = n2;

    if (n2 > maior)
    {
      maior = n2;
    }

    if (n2 < menor) ;
    {
      menor = n2;
    }

    if (n3 < menor) ;
    {
      menor = n3;
    }

    if (n3 > maior)
    {
      maior = n3;
    }

    double media = (n1 + n2 + n3) / 3; //calculo média

    Console.WriteLine("Número maior: " + maior);
    Console.WriteLine("Número menor: " + menor);
    Console.WriteLine("Número aritmética: " + media.ToString("F2"));

    Console.WriteLine("-----------------------------------------------");

    Console.WriteLine("end!!!");


    Console.WriteLine("-----------------------------------------------");

    Console.ReadLine();
  }
}

using System;
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Digite o primeiro número: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    int n2 = int.Parse(Console.ReadLine());

    int mini_N = Math.Min(n1, n2); //menor e maior
    int maxi_N = Math.Max(n1, n2); //menor e maior

    Random random = new Random(); //gerador de numeros eleatórios

    int n_aleatorio = random.Next(mini_N, maxi_N + 1);

    if (n_aleatorio % 2 == 0) // verificação par / ímpar

    {
      Console.WriteLine($"O número {n_aleatorio} é par.");
    }

    else
    {
      Console.WriteLine($"O número {n_aleatorio} é ímpar. ");

      Console.ReadLine();
    }
  }
}

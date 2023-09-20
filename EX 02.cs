using System;
public class Ex02
{
  public static void Main()
  {
    double compra, total_Pago; // Declaração de variável.

    Console.WriteLine("Qual foi o valor total da compra: R$ ");
    compra = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Valor pago pelo cliente: R$ ");
    total_Pago = Convert.ToDouble(Console.ReadLine());


    if (total_Pago < compra) // saldo de pagamento insuficiente
    {
      Console.WriteLine("A quantia paga pelo cliente é insuficiente ao valor da compra realizada");
    }

    else
    {
      double troco = total_Pago; // troco

      int nota50 = (int)(troco / 50);
      troco %= 50;

      int nota20 = (int)(troco / 20);
      troco %= 20;

      int nota10 = (int)(troco / 10);
      troco %= 10;

      int nota5 = (int)(troco / 5);
      troco %= 5;

      int nota2 = (int)(troco / 2);
      troco %= 2;

      int nota1 = (int)(troco / 1);
      troco %= 1;

      Console.WriteLine("Troco: R$ " + (compra - total_Pago));
      Console.WriteLine("Notas de R$ 50: " + nota50);
      Console.WriteLine("Notas de R$ 20: " + nota20);
      Console.WriteLine("Notas de R$ 10: " + nota10);
      Console.WriteLine("Notas de R$ 5: " + nota5);
      Console.WriteLine("Notas de R$ 2: " + nota2);
      Console.WriteLine("Notas de R$ 1: " + nota1);

      Console.WriteLine("-----------------------------------------------");

      Console.WriteLine("end!!!");


      Console.WriteLine("-----------------------------------------------");

      Console.ReadLine();

    }

  }
}

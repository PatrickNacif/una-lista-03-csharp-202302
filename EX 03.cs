using System;

class Program
{
  static void Main()
  {
    Console.Write("Informe o coeficiente a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Informe o coeficiente b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Informe o coeficiente c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    double delta = b * b - 4 * a * c;

    // Caso 'a' e 'b' forem iguais a '0', e 'c' diferente de '0'
    if (a == 0 && b == 0 && c != 0)
    {
      Console.WriteLine("Coeficientes informados incorretamente.");
    }
    // Caso 'a' for igual a '0' e 'b' diferente de '0'
    else if (a == 0 && b != 0)
    {
      Console.WriteLine("Essa é uma equação de primeiro grau.");
      double raiz = -c / b;
      Console.WriteLine("Raiz real: x = " + raiz);
    }
    // Caso 'delta' for menor que '0'
    else if (delta < 0)
    {
      Console.WriteLine("Esta equação não possui raízes reais.");
    }
    // Caso 'delta' for igual a '0'
    else if (delta == 0)
    {
      double raiz = -b / (2 * a);
      Console.WriteLine("Esta equação possui duas raízes reais iguais.");
      Console.WriteLine("Raiz real: x = " + raiz);
    }
    // Caso 'delta' seja maior que '0'
    else
    {
      double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
      double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

      Console.WriteLine("Esta equação possui duas raízes reais distintas.");
      Console.WriteLine("Raiz 1: x1 = " + x1);
      Console.WriteLine("Raiz 2: x2 = " + x2);
    }
    Console.ReadLine();
  }
}
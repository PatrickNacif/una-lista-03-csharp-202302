Console.WriteLine("Digite o primeiro número: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
double n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o símbolo da operação (+, -, *, / ou ^)");
char calculo = Convert.ToChar(Console.ReadLine());

double resultado = 0;

if (calculo == '+')
{
  resultado = n1 + n2;
  Console.WriteLine("O resultado da adição é: " + resultado.ToString("0.00"));
}
else if (calculo == '-')
{
  resultado = n1 - n2;
  Console.WriteLine("O resultado da subtração é: " + resultado.ToString("0.00"));
}
else if (calculo == '*')
{
  resultado = n1 * n2;
  Console.WriteLine("O resultado da multiplicação é: " + resultado.ToString("0.00"));
}
else if (calculo == '/')
  if (n2 != 0)
  {
    resultado = n1 / n2;
    Console.WriteLine("O resultado da divisão é: " + resultado.ToString("0.00"));
  }
  else
  {
    Console.WriteLine("Erro; Divisão por zero");
  }
else if (calculo == '^')
{
  resultado = Math.Pow(n1, n2);
  Console.WriteLine("O resultado da subtração é: " + resultado.ToString("0.00"));
}
else
{
  Console.WriteLine("Símbolo de operação inválido. Use um dos seguintes símbolos: +, -, *, /, ^.");
}
Console.ReadLine();

Console.WriteLine("Digite o indicador de operação (1 para perímetro do círculo, 2 para área do círculo, 3 para volume da esfera):");
int operacao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o raio:");
double raio = Convert.ToDouble(Console.ReadLine());

const double pi = 3.141592;

switch (operacao)
{
    case 1:
        // Cálculo do perímetro do círculo
        double perimetro = 2 * pi * raio;
        Console.WriteLine("O perímetro do círculo é: " + perimetro.ToString("0.00"));
        break;
    case 2:
        // Cálculo da área do círculo
        double area = pi * raio * raio;
        Console.WriteLine("A área do círculo é: " + area.ToString("0.00"));
        break;
    case 3:
        // Cálculo do volume da esfera
        double volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3);
        Console.WriteLine("O volume da esfera é: " + volume.ToString("0.00"));
        break;
    default:
        Console.WriteLine("Código de operação inválido. Por favor, escolha 1, 2 ou 3.");
        break;
}

Console.ReadLine();
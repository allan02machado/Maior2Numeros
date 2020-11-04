using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
        int valor1;
        int valor2;

        Console.WriteLine("Olá, seja bem-vindo ao compara dois números.");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Digite o primeiro número: ");
        valor1 = Convert.ToInt32(Console.ReadLine());

        valor2 = valor1;

        Console.Write("Digite o segundo número: ");
        valor2 = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Obrigado...");

        if(valor1 > valor2)
        {
            valor2 = valor1;
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("O maior número é: "+valor2);
        Console.ResetColor();
        }
    }
}

using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio14()
        {
            int celsius;
            Console.WriteLine("Efetue a leitura de uma temperatura medida em graus Celsius e faça a\n" +
                "conversão em graus Fahrenheit.\n");

            Console.Write("Escreva a temperatura em Ceusius: ");
            celsius = Convert.ToInt32(Console.ReadLine());
            Console.Write("A temperatura correspondente em Fahrenheit é: ");
            Console.Write(((9 * celsius) + 160) / 5);
            Console.ReadKey();
        }
    }
}
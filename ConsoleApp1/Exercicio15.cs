using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio15()
        {
            int celsius;
            Console.WriteLine("Efetue a leitura de uma temperatura medida em graus Fahrenheit e faça a\n" +
                "conversão em graus Celsius .\n");

            Console.Write("Escreva a temperatura em Fahrenheit: ");
            celsius = Convert.ToInt32(Console.ReadLine());
            Console.Write("A temperatura correspondente em Celsius é: ");
            Console.Write(((celsius - 32) * 5) / 9);
            Console.ReadKey();
        }
    }
}
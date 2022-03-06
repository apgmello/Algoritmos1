using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio18()
        {
            int valor01, valor02, resultado;
            Console.WriteLine("Efetue a leitura de dois valores numéricos inteiros e apresente o resultado da\n" +
                "diferença do maior valor pelo menor.\n");
            Console.Write("Valor 01: ");
            valor01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor 02: ");
            valor02 = Convert.ToInt32(Console.ReadLine());
            resultado = (valor01 - valor02);
            if (resultado < 0)
            {
                Console.Write("A diferença do maior valor pelo menor é: " + (resultado * (-1)));
            }
            else
            {
                Console.Write("A diferença do maior valor pelo menor é: "+ (resultado));
            }
            Console.ReadKey();
        }
    }
}
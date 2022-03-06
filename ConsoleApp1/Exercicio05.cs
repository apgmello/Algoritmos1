using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio05()
        {
            int valor01, valor02;
            Console.WriteLine("Crie um algoritmo que leia dois valores inteiros e informe se eles são iguais.\n" +
                "Caso sejam diferentes, informe qual deles é o maior.\n");
            Console.Write("Valor 1: ");
            valor01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor 2: ");
            valor02 = Convert.ToInt32(Console.ReadLine());
            if (valor01 == valor02)
            {
                Console.Write("Os valores são iguais");
            }
            else if (valor01 < valor02)
            {
                Console.Write("O Valor 2 é o maior");
            }
            else
            {
                Console.Write("O valor 1 é o maior");
            }
            Console.ReadKey();
        }
    }
}

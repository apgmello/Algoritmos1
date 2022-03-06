using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio09()
        {
            int valor01, valor02;
            Console.WriteLine("Escreva um programa que diga qual é o maior de dois números distintos\n");
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
                Console.Write("O valor 2 é o maior");
            }
            else
            {
                Console.Write("O valor 1 é o maior");
            }
            Console.ReadKey();
        }

    }
}
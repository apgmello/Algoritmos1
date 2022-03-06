using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio10()
        {
            int valor01, valor02, valor03;
            Console.WriteLine("Escreva um programa que calcule a média aritmética de três números digitados\n" +
                "pelo usuário.");
            Console.Write("Valor 01: ");
            valor01 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Valor 02: ");
            valor02 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Valor 03: ");
            valor03 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("A média aritimética é: ");
            Console.Write ((valor01 + valor02 + valor03)/3);
            Console.ReadKey();
        }

    }
}
using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio13()
        {
            int valor01;
            Console.WriteLine("Escreva um programa que receba um número e diga se ele está no intervalo\n" +
                "entre 100 e 200.\n");
            Console.Write("Escreva um numero entre 100 e 200: ");
            valor01 = Convert.ToInt32(Console.ReadLine());
            if (valor01 >= 100 && valor01 <= 200)
            {
                Console.WriteLine("Valor esta no intervalo");
            }
            else
            {
                Console.WriteLine("Valor fora do intervalor");
            }
            Console.ReadKey();
        }
    }
}
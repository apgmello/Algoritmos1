using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio06()
        {
            int valor01;
            Console.WriteLine("Faça um algoritmo que receba um número e diga se este está ou não no\n" +
                "intervalo entre 200 e 300.\n");
            Console.Write("Escreva um numero entre 200 e 300: ");
            valor01 = Convert.ToInt32(Console.ReadLine());
            if (valor01 >= 200 && valor01 <= 300)
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


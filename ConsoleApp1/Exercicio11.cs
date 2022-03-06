using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio11()
        {
            int valor;
            Console.Write("Escreva um programa que receba um número inteiro do usuário e diga se ele é\n" +
                "par ou impar.\n");
            Console.Write("Digite um valor inteiro: ");
            valor = Convert.ToInt32(Console.ReadLine());
            if (valor % 2 == 0) 
            {
                Console.Write("Valor é par");
            }
            else
            {
                Console.Write("Valor é impar");
            }
            Console.ReadKey();

        }
    }
}

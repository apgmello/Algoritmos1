using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio02()
        {
            decimal valor1, valor2;
            Console.WriteLine("Desenhe um algoritmo que receba dois números e mostre a soma, \n" +
                "a subtração, a multiplicação e a divisão dos números.\n");
            Console.Write("digite o valor 1: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite o valor 2: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("O resultado da soma é: ");
            Console.WriteLine(valor1 + valor2);
            Console.Write("O resultado da subtração é: ");
            Console.WriteLine(valor1 - valor2);
            if (valor2 == 0)
            {
                Console.WriteLine("Não é possivel dividir por 0");
            }
            else
            {
                Console.Write("O resultado da divisão é: ");
                Console.WriteLine(valor1 / valor2);
            }
            Console.Write("O resultado da multiplicação é: ");
            Console.Write(valor1 * valor2);
            Console.ReadKey();

        }
    }
}

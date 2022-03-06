
using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio01()
        {
            int @base, altura, resultado;
            Console.WriteLine("Construa um algoritmo que calcule o valor da área de um triangulo \n" +
                "a partir do valor da base e altura.\n");
            Console.Write("digite o valor da base: ");
            @base = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite o valor da altura: ");
            altura = Convert.ToInt32(Console.ReadLine());
            resultado = @base * altura;
            Console.Write("A área do triangulo é: ");
            Console.Write(resultado);
            Console.ReadKey();
        }

    }
}

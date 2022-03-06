using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio20()
        {
            int contador;
            Console.WriteLine("Faça um algoritmo que mostre os números de 100 a 1, usando comando (use o\n" +
                "comando WHILE ou FOR) de repetição.\n");
            Console.WriteLine("Utilizando FOR: ");
            for (contador = 100; contador > 0; contador--)
            {
                Console.WriteLine(contador);
            }
            Console.WriteLine("Utilizando While: ");
            contador = 100;
            while (contador > 0)
            {
                Console.WriteLine(contador);
                contador--;
            }
            Console.ReadKey();
        }
    }
}
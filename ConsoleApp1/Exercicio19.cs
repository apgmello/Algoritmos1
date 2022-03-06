using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio19()
        {
            int contador;
            Console.WriteLine("Faça um algoritmo que mostre os números de 1 a 10, usando comando (use o\n" +
                "comando WHILE ou FOR) de repetição.\n");
            Console.WriteLine("Utilizando FOR: ");
            for (contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }
            Console.WriteLine("Utilizando While: ");
            contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.ReadKey();
        }
    }
}
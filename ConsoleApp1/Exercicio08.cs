using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio08()
        {
            int idadeCompetidor;
            Console.WriteLine("Escreva um programa que informe a categoria de um jogador de futebol,\n" +
                "considerando sua idade: infanƟl(até 13 anos), juvenil(até 17 anos) ou sênior\n" +
                "(acima de 17 anos).\n");
            Console.Write("Escreva a idade do competidor: ");
            idadeCompetidor = Convert.ToInt32(Console.ReadLine());
            if (idadeCompetidor <= 13)
            {
                Console.Write("Categoria Infantil");
            }
            else if (idadeCompetidor <= 17)
            {
                Console.Write("Categoria Juvenil");
            }
            else
            {
                Console.Write("Categoria Sênior");
            }
            Console.ReadKey();
        }

    }
}
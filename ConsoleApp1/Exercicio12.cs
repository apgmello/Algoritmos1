using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio12()
        {
            string nomeAluno;
            decimal nota01, nota02, nota03;
            Console.Write("Escreva um programa que leia o nome de um aluno e as notas que ele obteve\n" +
                "nas três provas do semestre. No final, o programa deve informar o nome do\n" +
                "aluno e a sua média aritmética.\n");

            Console.Write("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();
            Console.Write("Nota da primeira Avaliação: ");
            nota01 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nota da segunda Avaliação: ");
            nota02 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nota da terceira Avaliação: ");
            nota03 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Média final do Aluno " + nomeAluno + ": ");
            Console.Write((nota01 + nota02 + nota03) / 3);
            Console.ReadKey();
        }
    }
}